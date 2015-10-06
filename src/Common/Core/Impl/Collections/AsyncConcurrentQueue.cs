using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Common.Core.Collections {
    public class AsyncConcurrentQueue<T> : IReadOnlyCollection<T> {
        private volatile ConcurrentQueue<T> _queue = new ConcurrentQueue<T>();
        private readonly ConcurrentQueue<TaskCompletionSource<T>> _pendingDequeue = new ConcurrentQueue<TaskCompletionSource<T>>();
        private int _queueCount;

        public void Enqueue(T item) {
            while (!TryEnqueue(item)) {
            }
        }

        private bool TryEnqueue(T item) {
            var count = Interlocked.Increment(ref _queueCount);

            if (count > 0) {
                _queue.Enqueue(item);
                return true;
            }

            TaskCompletionSource<T> pendingTcs;
            if (_pendingDequeue.TryDequeue(out pendingTcs)) {
                return pendingTcs.TrySetResult(item);
            }

            var spinWait = new SpinWait();
            while (!_pendingDequeue.TryDequeue(out pendingTcs)) {
                spinWait.SpinOnce();
            }

            return pendingTcs.TrySetResult(item);
        }

        public bool TryPeek(out T item) {
            return _queue.TryPeek(out item);
        }

        public Task<T> DequeueAsync() {
            var count = Interlocked.Decrement(ref _queueCount);

            if (count < 0) {
                TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
                _pendingDequeue.Enqueue(tcs);
                return tcs.Task;
            }

            return Task.FromResult(Dequeue());
        }

        public Task<T> DequeueAsync(CancellationToken cancellationToken) {
            var count = Interlocked.Decrement(ref _queueCount);

            if (count < 0) {
                TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
                cancellationToken.Register(() => tcs.TrySetCanceled());
                _pendingDequeue.Enqueue(tcs);
                return tcs.Task;
            }

            return Task.FromResult(Dequeue());
        }

        public IList<T> DequeueAll() {
            var list = new List<T>();
            var countToDequeue = GetCountToDequeue();
            for (var i = 0; i < countToDequeue; i++) {
                list.Add(Dequeue());
            }

            return list;
        }

        private int GetCountToDequeue() {
            var queueCount = Volatile.Read(ref _queueCount);

            while (true) {
                if (queueCount <= 0) {
                    return 0;
                }

                var countToDequeue = Interlocked.CompareExchange(ref _queueCount, 0, queueCount);
                if (countToDequeue == queueCount) {
                    return countToDequeue;
                }

                // In case _queueCount has been changed while we've been checking if it is greater than zero, try again
                queueCount = countToDequeue;
            }
        }

        private T Dequeue() {
            T item;
            if (_queue.TryDequeue(out item)) {
                return item;
            }

            var spinWait = new SpinWait();
            while (!_queue.TryDequeue(out item)) {
                spinWait.SpinOnce();
            }

            return item;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator() {
            return _queue.GetEnumerator();
        }

        public int Count => _queue.Count;
    }
}
