//Defines structures of code

namespace Mirix.Interpreter.Parser.Structures
{
    //Represents a construct such as a variable or (that's all actually as of now)          
    public class Construct
    {

    }

    public class Variable : Construct
    {
        private string identifier, typeName, initialValue;

        public string getIdentifier()
        {
            return identifier;
        }
    }
}