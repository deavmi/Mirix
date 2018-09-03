namespace Interpreter.Memory
{

    using System.Collections.Generic;

    //Stack-related routines and types
    namespace Stack
    {
        //Stack structure
        public sealed class Stack
        {
            //List of all the stack frames (in the order they were created) (initialized to contain no stack frames)
            private List<StackFrame> frames = new List<StackFrame>();

            public Stack()
            {

            }

            public StackFrame getCurrentFrame()
            {
                //TODO
            }
        }

        //Stack frame structure
        public sealed class StackFrame
        {

            //This stack frame's locals (initialized to contain no locals)
            private List<Variable> locals = new List<Variable>();

            //Create a new stack frame
            public StackFrame()
            {

            }

            //Add a local variable (add a variable to the stack frame)
            public void addVariable(Variable variable)
            {

            }

            //Returns an array of all the local variables (locals)
            public Variable[] getVariables()
            {

            }

            //Returns a variable of the given name
            public Variable getVariable(string identifier)
            {

            }
        }
    }

    //Heap-related routines and types
    namespace Heap
    {
        //Heap structure
        public sealed class Heap
        {
            //Add stuff here

            public Heap()
            {

            }

            //Clears all data from the Heap
            public void clear()
            {

            }
        }
    }

    //Code-related routines and types
    namespace Code
    {
        //ProgramData structure
        public sealed class ProgramData
        {
            //Array of blocks of code (functions/sub routines) that make up our program
            private List<Block> blocks;

            //Construct a new ProgramData with the given blocks (functions/sub routines)
            public ProgramData(List<Block> blocks)
            {
                this.blocks = blocks;
            }

        }

        //A Block of code (sub routine/function)
        public sealed class Block
        {
            //An array of the instructions this block contains
            private List<Instruction> instructions;

            public Block(List<Instruction> instructions)
            {
                this.instructions = instructions;
            }
        }
    }
}