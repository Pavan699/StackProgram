using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedListProgram
{
    class StackOperations
    {
        public void Switch()
        {
            StackLL<int> stack = new StackLL<int>();

            int count = 0, defCount = 1;
            while (defCount == 1)
            {
                Console.Write("Choose ==> \n1.Push\t 2.Display\t3.Peek\t 4.Pop\t 5.Empty\t 6.Exit\n");
                Console.Write("Input Plz : ");
                int check = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                switch (check)
                {
                    case 1:
                        Console.Write("Enter How Many Elements To Push Into the Stack :");
                        int numfirstadd = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numfirstadd; i++)
                        {
                            Console.Write("Enter Element To add : ");
                            int element = Convert.ToInt32(Console.ReadLine());
                            stack.Push(element);
                        }
                        count++;
                        break;
                    case 2:
                        stack.Print();
                        count++;
                        break;
                    case 3:
                        stack.Peek();
                        count++;
                        break;
                    case 4:
                        stack.Pop();
                        count++;
                        break;
                    case 5:
                        stack.Empty();
                        count++;
                        break;                    
                    default:
                        Console.WriteLine("Thank You.....!");
                        defCount++;
                        break;
                }
            }
            Console.WriteLine("Counter of the Operations Done is : " + count);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
