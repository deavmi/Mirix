//Defines structures of code

namespace Mirix.Interpreter.Data.Stack
{

    //A value/variable aaah TODO on the stack
    public class Variable
    {
        private string identifier, typeName, initialValue;

        //Returns this variables
        public string getIdentifier()
        {
            return identifier;
        }
    }
}