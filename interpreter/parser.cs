namespace Mirix
{
    namespace Interpreter
    {
        namespace Parser
        {

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