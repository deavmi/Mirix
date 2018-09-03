
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

        private void init()
        {

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

            programData.setBlockPointer

            //Begin execution of the program
            Console.Out.WriteLine("Environment all setup, beginning execution of program...");

            //Execution begins with the entry block which would be the first block in the ProgramData and hence the currentBlock
            Block entryBlock = programData.getCurrentBlock();

            //

        }

    }

}