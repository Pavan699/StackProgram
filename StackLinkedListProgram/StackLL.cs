using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedListProgram
{
    class StackLL<Stype>
    {
        public StackNode<Stype> top;
        public StackLL()
        {
            this.top = null;
        }
        /// <summary>
        /// Push() method to push the element in stack
        /// </summary>
        /// <param name="data">data holds the value</param>
        public void Push(Stype data)
        {
            StackNode<Stype> node = new StackNode<Stype>(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            //Console.WriteLine("Element {0} is Pushed in Stack", data);
        }
        /// <summary>
        /// Print() method to print the Stack
        /// </summary>
        public void Print()
        {
            StackNode<Stype> temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Peek() method to Print(Peek) the Top element
        /// </summary>
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Top(Peek) Element is : {0}",this.top.data);
        }
        /// <summary>
        /// Pop() method to Delete(Pop) the top element
        /// </summary>
        public void Pop()
        {
            if (this.top == null) 
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Popped Element is : {0}", this.top.data);
            this.top = this.top.next;
        }
        /// <summary>
        /// Empty() method to do stack empty
        /// </summary>
        public void Empty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
