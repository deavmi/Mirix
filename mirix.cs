using System;
using System.IO;

namespace Mirix
{
    using g;
    public sealed class Mirix
    {
        public static void Main(String[] args)
        {
            //If we have one argument then we can run that program
            if (args.Length == 1)
            {
                //If the argument `--help` is given then show the help screen
                if (args[0].Equals("--help"))
                {
                    //TODO: Show help scree
                }
                //Else, the gievn argument it the path to a file (the program to run)
                else
                {
                    //The argument is the file path of the source file to run
                    string sourceFile = args[0];

                    //If the file exists
                    if (File.Exists(sourceFile))
                    {
                        runProgram(sourceFile);
                    }
                    //Else if the file doesn't exist then it is an error
                    else
                    {
                        Console.Out.WriteLine("Could not find file \""+sourceFile+"\"!");
                    }
                }
            }
            //Else, it is an error
            else
            {
                Console.Out.WriteLine("Error starting Mirix");
            }
        }

        private static void runProgram(string filename)
        {
            Console.Out.WriteLine("Running program \"" + filename + "\"...");

            //Create a new Interpreter for the program to run in
            Interpreter.Interpreter interpreter = new Interpreter.Interpreter(filename);

            //Start running the inetrpreter with the given program
            interpreter.run();
        }
    }
}