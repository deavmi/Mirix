using System;
using System.IO;

namespace Mirix
{

    using Utils;

    public sealed class Mirix
    {

        //Whether or not debugging is enabled
        public static bool debuggingEnabled = false;

        public static void Main(String[] args)
        {
            //Testing
            CompressedBoolean j = new CompressedBoolean();
            Console.Out.WriteLine(j.getBoolean(0));
            Console.Out.WriteLine(j.getBoolean(1));
            Console.Out.WriteLine(j.getBoolean(2));
            Console.Out.WriteLine(j.getBoolean(3));
            Console.Out.WriteLine(j.getBoolean(4));
            Console.Out.WriteLine(j.getBoolean(5));
            Console.Out.WriteLine(j.getBoolean(6));
            Console.Out.WriteLine(j.getBoolean(7));

            j.setBoolean(0,true);
            Console.Out.WriteLine(j.getBoolean(0));
            Console.Out.WriteLine(j.getBoolean(1));

            j.setBoolean(1,true);
            Console.Out.WriteLine(j.getBoolean(0));
            Console.Out.WriteLine(j.getBoolean(1));

            
            
            
            


            //If we have one argument then we can run that program
            if (args.Length == 1)
            {
                //If the argument `--help` is given then show the help screen
                if (args[0].Equals("--help"))
                {
                    //TODO: Show help screen
                }
                //Else, the given argument it the path to a file (the program to run)
                else
                {
                    //The argument is the file path of the source file to run
                    string sourceFile = args[0];

                    //If the file exists
                    if (File.Exists(sourceFile))
                    {
                        //Start the interpreter with the given source file
                        runProgram(sourceFile);
                    }
                    //Else if the file doesn't exist then it is an error
                    else
                    {
                        Printer.WriteLine("Could not find file \""+sourceFile+"\"!",Printer.MessageType.ERROR);
                    }
                }
            }
            //Else, it is an error
            else
            {
                Printer.WriteLine("Error starting Mirix",Printer.MessageType.ERROR);
            }
        }

        //Start the interpreter and run it with the given source file
        private static void runProgram(string filename)
        {
            Printer.WriteLine("Running program \"" + filename + "\"...",Printer.MessageType.INFO);

            //Create a new Interpreter for the program to run in
            Interpreter.Interpreter interpreter = new Interpreter.Interpreter(filename);

            //Start running the inetrpreter with the given program
            interpreter.run();
        }
    }
}