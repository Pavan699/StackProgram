using System;
using System.Collections.Generic;
using System.Text;

namespace StackLinkedListProgram
{
    class StackNode<Stype>
    {
        public Stype data;//class instance
        public StackNode<Stype> next;
        public StackNode(Stype data)//constructor to assing the data
        {
            this.data = data;
        }
    }
}
