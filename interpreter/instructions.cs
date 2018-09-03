namespace Mirix
{
namespace Instructions
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

        //Returns the iden
        public String getIdentifier()
        {
            return identifier;
        }
    }
}}