namespace Mirix
{
    namespace Interpreter
    {
        namespace Parser
        {

            using System.Collections.Generic;

            //The Parser
            //Generates code
            public sealed class Parser
            {
                //Returns a Instruction[] of Instructions
                public static Instruction[] parse(Lexer.Token[] tokens)
                {
                    //The working set of Instructions
                    List<Instruction> instructions = new List<Instruction>();

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
                //The identifier of the variable
                private string identifier;

                //The initial value
                //TODO

                //The type
                //TODO

                public VariableDeclaration(string identifier, string initialValue, string type)
                {
                    this.identifier = identifier;
                }
            }
        }
    }
}