using System;

namespace StackLinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Stack Implementation");
            StackLL<int> stack = new StackLL<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Print();
        }
    }
}
