//Stack-related routines and types
namespace Mirix.Interpreter.Memory.Stack
{
    using System.Collections.Generic;

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