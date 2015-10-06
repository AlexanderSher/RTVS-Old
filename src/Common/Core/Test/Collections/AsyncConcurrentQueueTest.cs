using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Common.Core.Collections;
using Microsoft.UnitTests.Core.XUnit;

namespace Microsoft.Common.Core.Test.Collections {
    public class AsyncConcurrentQueueTest {
        [Test]
        public async Task DequeueAwaitEnqueue() {
            var queue = new AsyncConcurrentQueue<int>();
            Delay().ContinueWith(_ => queue.Enqueue(5)).DoNotWait();
            var result = await queue.DequeueAsync();
            result.Should().Be(5);
        }

        [Test]
        public async Task DequeueDequeueAwaitEnqueueEnqueue() {
            var queue = new AsyncConcurrentQueue<int>();
            var t1 = queue.DequeueAsync();
            var t2 = queue.DequeueAsync();

            t1.IsCompleted.Should().BeFalse();
            t2.IsCompleted.Should().BeFalse();

            Delay().ContinueWith(_ => queue.Enqueue(1)).DoNotWait();
            await Task.WhenAny(t1, t2);

            t1.IsCompleted.Should().BeTrue();
            t2.IsCompleted.Should().BeFalse();
            t1.Result.Should().Be(1);

            Delay().ContinueWith(_ => queue.Enqueue(2)).DoNotWait();

            await t2;
            t2.IsCompleted.Should().BeTrue();
            t2.Result.Should().Be(2);
        }

        [Test]
        public async Task EnqueueDequeueDequeueEnqueue() {
            var queue = new AsyncConcurrentQueue<int>();
            Task<int> t1 = null;
            Task<int> t2 = null;
            Action<Task> a1 = _ => queue.Enqueue(1);
            Action<Task> a2 = _ => t1 = queue.DequeueAsync();
            Action<Task> a3 = _ => t2 = queue.DequeueAsync();
            Action<Task> a4 = _ => queue.Enqueue(2);

            await Task.WhenAll(
                Delay().ContinueWith(a1),
                Delay().ContinueWith(a2),
                Delay().ContinueWith(a3),
                Delay().ContinueWith(a4));

            t1.Should().NotBeNull();
            t1.IsCompleted.Should().BeTrue();
            t2.Should().NotBeNull();
            t2.IsCompleted.Should().BeTrue();

            new[] { t1.Result, t2.Result }.Should().BeEquivalentTo(1, 2);
        }

        [Test]
        public void EnqueueDequeue1000() {
            var count = 1000;
            var queue = new AsyncConcurrentQueue<int>();
            var dequeueTasks = new ConcurrentQueue<Task<int>>();
            var input = Enumerable.Range(0, count).ToList();

            var tasks = input
                .SelectMany(i => new Action[] {
                    () => queue.Enqueue(i),
                    () => dequeueTasks.Enqueue(queue.DequeueAsync())
                })
                .ToArray();

            Parallel.Invoke(tasks);

            dequeueTasks.Should().HaveCount(count);
            dequeueTasks.Select(t => t.IsCompleted).Should().Equal(Enumerable.Repeat(true, count));
            dequeueTasks.Select(t => t.Result).Should().BeEquivalentTo(input);
        }

        [Test]
        public async Task DequeueDequeueAwaitCancelEnqueue() {
            var queue = new AsyncConcurrentQueue<int>();
            var cts = new CancellationTokenSource();
            var t1 = queue.DequeueAsync(cts.Token);
            var t2 = queue.DequeueAsync();

            t1.IsCompleted.Should().BeFalse();
            t2.IsCompleted.Should().BeFalse();

            cts.Cancel();

            t1.IsCompleted.Should().BeTrue();
            t2.IsCompleted.Should().BeFalse();
            t1.IsCanceled.Should().BeTrue();

            Delay().ContinueWith(_ => queue.Enqueue(1)).DoNotWait();
            await t2;

            t1.IsCompleted.Should().BeTrue();
            t2.IsCompleted.Should().BeTrue();
            t2.Result.Should().Be(1);

            queue.Count.Should().Be(0);
        }

        [Test]
        public void EnqueueCancelDequeue() {
            var queue = new AsyncConcurrentQueue<object>();
            var cts = new CancellationTokenSource();

            var expected = new object();
            queue.Enqueue(expected);
            cts.Cancel();
            object actual = null;
            Func<Task> f = async () => actual = await queue.DequeueAsync(cts.Token);

            f.ShouldNotThrow<TaskCanceledException>();

            actual.Should().BeSameAs(expected);
        }

        [Test]
        public void EnqueueDequeueCancelEnqueue() {
            var queue = new AsyncConcurrentQueue<int>();
            var cts = new CancellationTokenSource();
            var spin = new SpinWait();

            Task<int> t1 = null;
            Task<int> t2 = null;
            Action a1 = () => queue.Enqueue(1);
            Action a2 = () => t1 = queue.DequeueAsync();
            Action a3 = () => t2 = queue.DequeueAsync(cts.Token);
            Action a4 = () => {
                spin.SpinOnce();
                spin.SpinOnce();
                spin.SpinOnce();
                queue.Enqueue(2);
            };
            cts.Cancel();

            Parallel.Invoke(a1, a2, a3, a4);

            t1.Should().NotBeNull();
            t1.IsCompleted.Should().BeTrue();
            t2.Should().NotBeNull();
            t2.IsCompleted.Should().BeTrue();

            queue.Count.Should().Be(0);
        }

        [Test]
        public void EnqueueDequeueCancel1000() {
            var count = 1000;
            var queue = new AsyncConcurrentQueue<int>();
            var dequeueTasks = new ConcurrentQueue<Task<int>>();
            var input = Enumerable.Range(0, count).ToList();
            var cts = new CancellationTokenSource();
            cts.Cancel();

            var actions = input
                .SelectMany(i => new Action[] {
                    () => dequeueTasks.Enqueue(queue.DequeueAsync(cts.Token)),
                    () => queue.Enqueue(i)
                }).ToArray();


            Parallel.Invoke(actions);

            dequeueTasks.Should().HaveCount(count);
            dequeueTasks.Count(t => t.IsCompleted).Should().Be(count);
            dequeueTasks.Count(t => t.IsCanceled).Should().Be(queue.Count);
            dequeueTasks.Count(t => t.Status == TaskStatus.RanToCompletion).Should().Be(count - queue.Count);
        }

        [Test]
        public void EnqueueDequeueAllDequeue() {
            var queue = new AsyncConcurrentQueue<int>();
            Task<int> t = null;
            IList<int> l = null;
            Action a1 = () => queue.Enqueue(3);
            Action a2 = () => l = queue.DequeueAll();
            Action a3 = () => t = queue.DequeueAsync();
            Action a4 = () => queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(2);

            Parallel.Invoke(a1, a2, a3, a4);

            t.Should().NotBeNull();
            t.IsCompleted.Should().BeTrue();
            l.Should().NotContain(t.Result);
        }

        private static Task Delay() {
            return Task.Delay(30);
        }
    }
}
