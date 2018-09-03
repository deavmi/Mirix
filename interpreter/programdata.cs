//Code-related routines and types
namespace Mirix.Interpreter.Memory.Code
{
    using System.Collections.Generic;
    using Instructions;
    
    //ProgramData structure
    public sealed class ProgramData
    {
        //Array of blocks of code (functions/sub routines) that make up our program
        private List<Block> blocks;

        //Pointer to the code block currently being executed

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

        //Pointer to the currently executing instruction
        private int instructionPointer;

        public Block(List<Instruction> instructions)
        {
            //Add the intructions to this new code block
            this.instructions = instructions;

            //Set the instruction pointer to point to the first instruction
            instructionPointer = 0;
        }
    }
}