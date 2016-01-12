using System;

namespace HandsOnCustomEvent
{
    public sealed class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }
}
