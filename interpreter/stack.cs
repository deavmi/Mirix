//Stack-related routines and types
namespace Mirix.Interpreter.Data.Stack
{
    using System.Collections.Generic;
    using Parser.Structures;

    //Stack structure
    public sealed class Stack
    {
        //List of all the stack frames (in the order they were created) (initialized to contain no stack frames)
        private List<StackFrame> frames = new List<StackFrame>();

        //Pointer to the current Stack Frame
        private int stackFramePointer;

        //Construct a new Stack with the given initial StackFrame
        public Stack(StackFrame initialStackFrame)
        {
            //Add the initial stack frame to the stack
            frames.Add(initialStackFrame);

            //We now point to the initial (first) frame on the Stack
            stackFramePointer = 0;
        }

        //Returns the current stack frame (as pointed to by the frame pointer)
        public StackFrame getCurrentFrame()
        {
            //TODO: Use the porperty kak
            StackFrame currentStackFrame = frames.ToArray()[stackFramePointer];
            return currentStackFrame;
        }

        //Adds a new stack frame as the current frame
        public void addFrame(StackFrame newStackFrame)
        {
            //Add the next frame
            frames.Add(newStackFrame);

            //Now make the stack frame pointer point to this (the newest) stack frame
            stackFramePointer++;
        }

        //Clears the current frame and sets the frame pointer to the previous frame
        public void returnFrame()
        {
            //Removs the frame at the current stack frame pointer
            frames.RemoveAt(stackFramePointer);

            //Now decrement the stack frame pointer to point to the frame that (was) before this one
            stackFramePointer--;
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