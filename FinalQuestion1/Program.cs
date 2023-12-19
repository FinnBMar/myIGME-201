using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQuestion1 //Finn Marable IGME 201 Final Exam Question 1
{
    class MyStack
    {
        private List<int> stackList;

        public MyStack()
        {
            stackList = new List<int>();
        }

        public void Push(int n)
        {
            stackList.Add(n);
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }

            int poppedValue = stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);
            return poppedValue;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return stackList[stackList.Count - 1];
        }

        public bool IsEmpty()
        {
            return stackList.Count == 0;
        }
    }
    class Program
    {
        static void Main()
        {
            // Example usage
            MyStack myStack = new MyStack();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Console.WriteLine("Peek: " + myStack.Peek());

            Console.WriteLine("Pop: " + myStack.Pop());
            Console.WriteLine("Pop: " + myStack.Pop());

            myStack.Push(4);

            Console.WriteLine("Peek: " + myStack.Peek());
        }
    }

}
