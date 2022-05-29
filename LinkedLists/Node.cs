using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Node
    {

        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;                             //stores the info
            this.next = null;                            //stores next node positon
        }
    }
}