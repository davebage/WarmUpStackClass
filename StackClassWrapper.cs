using System;
using System.Collections;
using System.Dynamic;

namespace WarmUpStackClass
{
    public class StackClassWrapper
    {
        private Stack myStack;

        public StackClassWrapper()
        {
            myStack = new Stack();
        }

        public void Push(object @object)
        {
            myStack.Push(@object);
        }

        public Object Pop()
        {
            return myStack.Pop();
        }

        public Object Peek()
        {
            return myStack.Peek();
        }


    }
}
