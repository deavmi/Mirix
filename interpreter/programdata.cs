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
        private int currentBlockPointer;

        //Construct a new ProgramData with the given blocks (functions/sub routines)
        public ProgramData(List<Block> blocks)
        {
            //Add the blocks
            this.blocks = blocks;

            //Set the currentBlockPointer to the first block (execution begins here)
            currentBlockPointer = 0;
        }

        public void setBlockPointer(int blockIndex)
        {

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

        public Instruction getCurrentInstruction()
        {
            return instructions.ToArray()[instructionPointer];
        }

        public void decrementPointer()
        {
            instructionPointer--;
        }

        public void incrementPointer()
        {
            instructionPointer++;
        }

        public void setPointer(int index)
        {
            instructionPointer = index;
        }
    }
}