namespace Mirix
{
   
    namespace Interpreter
    {
         using Lexer;
         using System.Collections.Generic;
         using System.IO;
         using System;
         using Utils;

        public sealed class Interpreter
        {

            //Pathname of source file
            private string sourceFile;

            //Constucts a new Interpreter with the given source file
            public Interpreter(string sourceFile)
            {
                this.sourceFile = sourceFile;
            }

            //Read characters from a file (ASCII support only)
            private char[] getSourceCode()
            {
                //The read-in bytes from the source file
                List<byte> bytes = new List<byte>();

                //Setup the file reader
                FileStream fileInStream = File.Open(sourceFile,FileMode.Open);

                //Read in each byte
                while(true)
                {
                    //Read either a byte or get an EOF (-1)
                    int readResult = fileInStream.ReadByte();

                    //If the end-of-file (EOF) is reached
                    if(readResult == -1)
                    {
                        Printer.WriteLine("End of file reached.",Printer.MessageType.INFO);
                        break;
                    }
                    //Read the byte
                    else
                    {
                        //The read byte
                        byte byteRead = (byte)readResult;

                        //Add the byte to the list
                        bytes.Add(byteRead);
                    }
                }

                //TODO: Raise an exception if the list is empty (meaning that the file was empty)
                int bytesRead = bytes.Count;
                Printer.WriteLine("Bytes read from source file: " + bytesRead,Printer.MessageType.INFO);

                //The final set of bytes
                byte[] finalBytes = bytes.ToArray();

                //The final characters (ASCII ones only)
                char[] finalChars = new char[finalBytes.Length];

                //Generate the characters from the bytes
                for(int i = 0; i < finalBytes.Length; i++)
                {
                    finalChars[i] = (char)finalBytes[i];
                }

                return finalChars;
            }

            //Starts execution of the program
            public void run() 
            {
                //Get Tokens
                Token[] tokens = Lexer.Lexer.getTokens(getSourceCode());
                Printer.WriteLine("Bytes read from source file: " + bytesRead,null);
            }
        }
    }
}