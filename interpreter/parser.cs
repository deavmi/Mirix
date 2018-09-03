namespace Mirix
{
    namespace Interpreter
    {
        namespace Parser
        {

            using System.Collections.Generic;
            using System;
            using Instructions;

            //The Parser
            //Generates code
            public sealed class Parser
            {
                //Returns a Instruction[] of Instructions
                public static Instruction[] parse(Lexer.Token[] tokens)
                {
                    //The working set of Instructions
                    List<Instruction> instructions = new List<Instruction>();

                    //Begin to look for the keyword `function` then a `name` then `{`
                    //then start generating code for this function in there and stop when
                    //we encounter a `}`.
                    //Repeat this process

                    bool error = false;

                    //Loop through the tokens and build instructions
                    int i = 0;
                    while(i < tokens.Length)
                    {
                        //Current token
                        string currentToken = tokens[i].getToken();


                        //First expect the keyword `function`
                        if(i == 0)
                        {
                           if(currentToken.Equals("function"))
                           {
                               //If we get the keyword `function` then we can go ahead
                               continue;
                           }
                           else
                           {
                               Console.Out.WriteLine("Expected function, got \""+currentToken+"\".");
                               error = true;
                               break;
                           }
                        }
                        //Secondly expect the a name for the function
                        else if(i == 1)
                        {
                            tokens.AsSpan();//TODO cotinue here
                        }

                        Console.Out.WriteLine("Currently processing token \""+currentToken+"\"");

                        //Check if any errors occurred
                        if(error)
                        {
                            Console.Out.WriteLine("Errors occurred during parsing.");
                        }
                        else
                        {
                            //All is good
                            Console.Out.WriteLine("Parsing succeeded");
                        }
                    }


                    return instructions.ToArray();
                }

                private void parseFunction()
                {
                    //TODO: Add function parsing code here
                }
            }

           
        }
    }
}