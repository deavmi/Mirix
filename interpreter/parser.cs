namespace Mirix
{
    namespace Interpreter
    {
        namespace Parser
        {

            using System.Collections.Generic;
            using System;

            //The Parser
            //Generates code
            public sealed class Parser
            {
                //Returns a Instruction[] of Instructions
                public static Instruction[] parse(Lexer.Token[] tokens)
                {
                    //The working set of Instructions
                    List<Instruction> instructions = new List<Instruction>();

                    //Loop through the tokens and build instructions
                    int i = 0;
                    while(i < tokens.Length)
                    {
                        //Current token
                        string currentToken = tokens[i].getToken();

                        //If the token is "var"
                        if(currentToken.Equals("var"))
                        {
                            //Await a type name
                            i++;
                            string typeName = tokens[i].getToken();
                            Console.Out.WriteLine("TypeName: " + typeName);

                            //Await a variable name
                            i++;
                            string variableName = tokens[i].getToken();
                            Console.Out.WriteLine("VariableName: " + variableName);

                            

                            //Await either semi-colon or comma, or equals
                            i++;
                            string nextItem = tokens[i].getToken();

                            //If we are a semi-colon (ends variable declaration)
                            if(nextItem.Equals(";"))
                            {
                                Console.Out.WriteLine("Semi-colon encountered, ending variable declaration");
                                VariableDeclaration varDec = new VariableDeclaration(typeName,variableName);
                            }
                            //If we are an equals sign (assignment with variable declaration)
                            else if(nextItem.Equals("="))
                            {
                                //TODO: Add a while loop here as this can go on for some time.
                                //TODO, don't implement this as a feature.
                            }
                            //If we are a comma (declaring multiple variables)
                            else if(nextItem.Equals(","))
                            {

                            }
                            

                            
                        }

                        Console.Out.WriteLine("Currently processing token \""+currentToken+"\"");
                    }


                    return instructions.ToArray();
                }
            }

            //Represents an instruction
            public class Instruction
            {

            }

            /*
             * VariableDeclaration
             * 
             * This instruction represents the declaration of a variable.
             */
            public class VariableDeclaration : Instruction
            {
                //The type, identifier and initial value of the variable
                private string typeName, identifier, initialValue;

                public VariableDeclaration(string typeName, string identifier)
                {
                    this.typeName = typeName;
                    this.identifier = identifier;
                }

                public VariableDeclaration(string typeName, string identifier, string initialValue)
                {
                     this.typeName = typeName;
                     this.identifier = identifier;
                     this.initialValue = initialValue;
                }

                //Returns the idetifier
                public String getIdentifier()
                {
                    return identifier;
                }
            }
        }
    }
}