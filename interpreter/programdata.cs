//Code-related routines and types
namespace Mirix.Interpreter.Memory.Code
{
    using System.Collections.Generic;

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