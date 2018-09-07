//Code-related routines and types
namespace Mirix.Interpreter.Data.Code
{
    using System.Collections.Generic;
    using Instructions;

    //ProgramData structure (holds the generated blocks)
    //TODO remove pointer, per new call we must make a copy of the code from here
    public sealed class ProgramData
    {
        //Array of blocks of code (functions/sub routines) that make up our program
        private Block[] blocks;

        //Construct a new ProgramData with the given blocks (functions/sub routines)
        public ProgramData(Block[] blocks)
        {
            //Add the blocks
            this.blocks = blocks;
        }

        //Returns a list of all this program's blocks (functions/sub-routines)
        public Block[] getBlocks()
        {
            return blocks;
        }
    }

    //BlockStack
    //
    //Holds a stack of Blocks
    public sealed class BlockStack //TODO: fix this all
    {
        //An array of the blocks
        private List<Block> blocks = nameof List<Block>();

        //Pointer to the code block currently being executed
        private int currentBlockPointer;

        //Construct a new BlockStack
        public BlockStack()
        {
            //Set the currentBlockPointer to the first block (execution begins here)
            currentBlockPointer = 0;
        }

        public void returnBlock()
        {
            //TODO: Implement me
            currentBlockPointer++;
        }

        public Block getCurrentBlock()
        {
            //TODO: Implement me
            return blocks.ToArray()[currentBlockPointer];
        }

        public void addBlock(Block block)
        {
            //Add the given block
            blocks.Add(block);

            //Increment the block pointer
            currentBlockPointer++;
        }

        public void setBlockPointer(int blockIndex)
        {
            currentBlockPointer = blockIndex;
        }
    }

    //Removed instructiojn pointer fro here, this must be in the executor code rather, block must not change
    //A Block of code (sub routine/function)
    public sealed class Block
    {
        //An array of the instructions this block contains
        private List<Instruction> instructions;

        //Pointer to the currently executing instruction
        private int instructionPointer;

        //The name of the Block (function/subroutine)
        private string blockName;

        //Construct a new Block (functions/subroutine) with the given set of instructions
        public Block(string blockName, List<Instruction> instructions)
        {
            //Add the intructions to this new code block
            this.instructions = instructions;

            //Set the instruction pointer to point to the first instruction
            instructionPointer = 0;

            //Set the name of this block (the function's name)
            this.blockName = blockName;
        }

        //Returns this Block's name
        public string getBlockName()
        {
            return blockName;
        }

        //Return the instruction pointed to by the instruction pointer
        public Instruction getCurrentInstruction()
        {
            return instructions.ToArray()[instructionPointer];
        }

        //Get the count of instructions
        public int getInstructionCount()
        {
            return instructions.Count;
        }

        //Decrement the instruction pointer
        public void decrementPointer()
        {
            instructionPointer--;
        }

        //Increment the instruction pointer
        public void incrementPointer()
        {
            instructionPointer++;
        }

        //Set the instruction pointer
        public void setPointer(int index)
        {
            instructionPointer = index;
        }
    }
}