
namespace Mirix.Interpreter.Execution
{

    using Data.Code;
    using Data.Stack;
    using Data.Heap;
    using Utils;
    using System;

    //Runner
    //
    //This executes the program.
    public sealed class Runner
    {
        //The Heap of this program
        private Heap heap;

        //The Stack of this program
        private Stack stack;

        //The ProgramState (holds the Blocks)
        private ProgramData programData;

        //Construct a new runner
        public Runner(ProgramData programData)
        {
            //Set this program's ProgramData
            this.programData = programData;
        }

        //Returns this program's Heap
        public Heap getHeap()
        {
            return heap;
        }

        //Returns this program's Stack
        public Stack getStack()
        {
            return stack;
        }

        //Return this program's ProgramData
        public ProgramData getProgramData()
        {
            return programData;
        }

        //Start execution of the program
        public void run()
        {
            //Setup running environment
            Console.Out.WriteLine("Setting up environment...");

            //Create the initial stack frame
            StackFrame initialStackFrame = new StackFrame();

            //Setup the stack with the initial stack frame `initialStackFrame`
            stack = new Stack(initialStackFrame);

            //Setup the heap
            heap = new Heap();

            //Begin execution of the program
            Console.Out.WriteLine("Environment all setup, beginning execution of program...");

            //Execution begins with the entry block which would be the first block in the ProgramData and hence the currentBlock
            Block entryBlock = programData.getCurrentBlock();

            //Loop through each instruction of the entryBlock and execute them whilst the instruction pointer is (//TODO)
            while(true)
            {
                //Get the current block being executed
                //Note: On first run this block will be the `entryBlock` (the first in the List<Block>)
                Block currentBlock = programData.getCurrentBlock();

                //Execute the instruction in the block `currentBlock` pointed to by the instruction pointer in the block `currentBlock`
                Instructions.Instruction currentInstruction = currentBlock.getCurrentInstruction();
                bool errored = currentInstruction.execute();

                //After execution check if the program must still be running (or has been set to false and hence an error occurred)
                if(errored)
                {
                    Console.Out.WriteLine("An error occurred somewhere in executing the instruction and the interpreter will now halt.");
                    break;
                }


            }
            Console.Out.WriteLine("Code run completed");
        }

    }

}