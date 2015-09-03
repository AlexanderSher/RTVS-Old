﻿using System;
using Microsoft.Languages.Core.Text;
using Microsoft.Languages.Editor.Selection;
using Microsoft.Languages.Editor.Text;
using Microsoft.R.Core.Tokens;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Projection;

namespace Microsoft.R.Editor.Selection
{
    /// <summary>
    /// JScript selection tracker. Helps preserve selection and correct
    /// caret position during script autoformatting. Uses tokenizer to
    /// calculate where caret should be after autoatic formatting.
    /// </summary>
    internal sealed class RSelectionTracker : SelectionTracker
    {
        int _index;
        int _offset;

        /// <summary>
        /// SelectionTracker constructor
        /// </summary>
        /// <param name="textView">Text view</param>
        /// <param name="textBuffer">Editor text buffer (may be different from one attached to text view)</param>
        public RSelectionTracker(ITextView textView, ITextBuffer textBuffer)
            : base(textView)
        {
            TextBuffer = textBuffer;
        }

        #region ISelectionTracker

        /// <summary>
        /// Editor text buffer.
        /// </summary>
        public ITextBuffer TextBuffer { get; private set; }

        /// <summary>
        /// Saves current selection
        /// </summary>
        public override void StartTracking(bool automaticTracking)
        {
            int position = TextView.Caret.Position.BufferPosition;
            TokenFromPosition(TextBuffer.CurrentSnapshot, position, out _index, out _offset);

            base.StartTracking(false);
        }

        /// <summary>
        /// Restores saved selection
        /// </summary>
        public override void EndTracking()
        {
            int position = PositionFromTokens(TextBuffer.CurrentSnapshot, _index, _offset);
            if (position >= 0)
            {
                PositionAfterChanges = new SnapshotPoint(TextBuffer.CurrentSnapshot, position);
            }

            MoveToAfterChanges();
        }
        #endregion

        private static void TokenFromPosition(ITextSnapshot snapshot, int position, out int itemIndex, out int offset)
        {
            // Normally token stream does not change after formatting so we can simply rely on the fact 
            // that caret position is going to remain relative to the same token index

            itemIndex = -1;
            offset = 0;

            var tokenizer = new RTokenizer();
            IReadOnlyTextRangeCollection<RToken> tokens = tokenizer.Tokenize(new TextProvider(snapshot), 0, snapshot.Length, true);

            // Check if position is adjacent to previous token
            itemIndex = tokens.GetFirstItemBeforePosition(position);
            if (itemIndex >= 0 && tokens[itemIndex].End == position)
            {
                offset = -tokens[itemIndex].Length;
                return;
            }

            itemIndex = tokens.GetFirstItemAfterOrAtPosition(position);
            if (itemIndex >= 0)
            {
                // If two tokens are adjacent, gravity is negative, i.e. caret travels
                // with preceding token so it won't just to aniother line if, say, 
                // formatter decides to insert a new line between tokens.

                if (itemIndex > 0 && tokens[itemIndex - 1].End == tokens[itemIndex].Start)
                {
                    itemIndex--;
                }

                offset = tokens[itemIndex].Start - position;
            }
        }

        private static int PositionFromTokens(ITextSnapshot snapshot, int itemIndex, int offset)
        {
            var tokenizer = new RTokenizer();
            var tokens = tokenizer.Tokenize(new TextProvider(snapshot), 0, snapshot.Length, true);

            if (itemIndex >= 0 && itemIndex < tokens.Count)
            {
                int position = tokens[itemIndex].Start - offset;

                position = Math.Min(position, snapshot.Length);
                position = Math.Max(position, 0);

                return position;
            }

            return snapshot.Length;
        }
    }
}