namespace Mirix.Instructions
{
    using System;

    //Represents an instruction
    public class Instruction
    {
        //TODO:
        //Make abstract []
        //Add abstract method
        //Add other kak
    }

    /*
     * Call
     *
     * This instructions represents a call to another function.s
     */
    public sealed class FunctionCall : Instruction
    {

        //The name of the function to be called
        private string functionName;

        //Construct a new FunctionCall to the function with the name `functionName`
        public FunctionCall(string functionName)
        {
            this.functionName = functionName;
        }

        //Returns the name of the function to be called
        public string getFunctionName()
        {
            return functionName;
        }
    }


    /*
    * VariableAssignment
    *
    * This instructions represents an assignment of a value to a variable.
    */
    public sealed class VariableAssignment : Instruction
    {
        //TODO: Implement me
    }

    /*
     * VariableDeclaration (StackStore)
     * 
     * This instruction represents the declaration of a variable.
     */
    public sealed class VariableDeclaration : Instruction
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
}