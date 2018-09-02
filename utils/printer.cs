namespace Utils
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
            Console.Out.WriteLine(messageType + ": " + message);
        }

        public static void Write(string message, MessageType messageType)
        {
            Console.Out.Write(messageType + ": " + message);
        }
    }
}