//Holds the block pointer (which block is being executed now)
//Holds the instruction pointer, which instruction in said block is being executed now

namespace Mirix.Interpreter.Execution
{

    using Data.Heap;
    using Data.Stack;
    using Data.Code;

    //ProgramState
    //This holds the state of the program, such as the program's Stack, Heap and Program Data.
    public class ProgramState
    {

        //The Heap of this program
        private Heap heap;

        //The Stack of this program
        private Stack stack;

        //The ProgramData of this program
        private ProgramData programData;

        //Pointer 

        public ProgramState()
        {

        }

        private int blockPointer;
    }

}