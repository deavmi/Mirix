namespace Mirix.Instructions
{
    using System;

    using Interpreter.Execution;
    using Interpreter.Data.Code;
    //using Code;//these namepscas get on my tits TODO: revise me

    //Represents an instruction
    public abstract class Instruction
    {

        //The Runner object that all instructions come from
        //This is here so that instructions can access the program's Code (ProgramData), Stack and Heap.
        public static Runner runner;

        //All Instructions must implement this method in which they execute their operations
        public abstract bool execute();
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

        //When we execute a function call what we want to do is the following:
        //TODO new keyword?
        public override bool execute()
        {
            //Whether or not an error occurred whilst executing this instruction
            bool errored = false;

            Console.Out.WriteLine("FunctionCall: Attempting to call function with name \""+functionName+"\"...");

            //First we must find if a function with that name exists
            ProgramData programData = runner.getProgramData();

            //The blocks's to search through
            Block[] blocks = programData.getBlocks();

            //The Block to execute
            Block executeBlock = null;

            //Find a block with the name of `functionName`
            foreach(Block block in blocks)
            {
                if(block.getBlockName().Equals(functionName))
                {
                    executeBlock = block;
                    Console.Out.WriteLine("Found a block/function with name\""+block.getBlockName()+"\".");
                    break; 
                }
            }

            //If no block with the given name `functionName` was found then `executeBlock` will hold the value `null reference`
            if(executeBlock == null)
            {
                errored = true;
                Console.Out.WriteLine("Could not find a block/function with name \""+functionName+"\".");
            }
            else
            {
                //TODO: Add code to execute the block here
                //We must update stuff, new stack, etc.
                Interpreter.Data.Stack.Stack stack = runner.getStack();

                //Generate a new StackFrame
                Interpreter.Data.Stack.StackFrame stackFrame = new Interpreter.Data.Stack.StackFrame();
                
                //Add the stack frame to the stack
                stack.addFrame(stackFrame);

                //Now we need to save kak right?
                //TODO: Save IP?
                //or already saved
                //TODO restore IP later?
                //TODO select the correct block now via block pointer
            }

            return errored;
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
        public override bool execute()
        {
            //TODO
            bool errored = false;


            return errored;
        }

        private isDeclared()
        {

        }
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