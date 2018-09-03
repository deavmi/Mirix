
namespace Mirix.Interpreter.Execution
{

    using Data.Code;

    //Runner
    //
    //This executes the program.
    public sealed class Runner
    {

        //The ProgramState (holds the Stack, Heap and ProgramData)
        private ProgramData programData;

        //Construct a new runner
        public Runner(ProgramData programData)
        {
            //Set this program's ProgramData
            this.programData = programData;

            init();
        }

        private void init()
        {
            programData.setBlockPointer
        }

        public void run()
        {
            //Start execution of the program

            //Execution begins with the entry block which would be the first block in the ProgramData and hence the currentBlock
            Block entryBlock = programData.getCurrentBlock();
            
        }

    }

}