namespace Mirix.Utils
{

    using System;

    public sealed class Printer
    {
        public enum MessageType
        {
            WARNING, INFO, ERROR
        }

        public static void WriteLine(string message, MessageType messageType)
        {
            if (Mirix.debuggingEnabled)
            {
                Console.Out.WriteLine(messageType + ": " + message);
            }
        }

        public static void Write(string message, MessageType messageType)
        {
            if (Mirix.debuggingEnabled)
            {
                Console.Out.Write(messageType + ": " + message);
            }
        }
    }
}