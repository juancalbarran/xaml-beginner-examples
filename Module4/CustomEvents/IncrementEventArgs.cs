using System;

namespace CustomEvents
{
    public sealed class IncrementEventArgs : EventArgs
    {
        public IncrementEventArgs(int incrementValue)
        {
            this.IncrementValue = incrementValue;
        }

        public int IncrementValue { get; private set; }
    }
}