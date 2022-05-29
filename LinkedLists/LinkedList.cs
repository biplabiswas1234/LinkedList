using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LinkedList
    {
        public Node head;
        public Node tail;
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public void CreateNode(Node node)
        {
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                //if node then add new node as head
                node.next = head;
                head = node;
            }

        }
        public void Display()
        {
            //temp variable will be head
            Node temp = head;
            //check if list is empty or not
            if (this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + "");
                //check until temp is null
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                //for traversing the node
                temp = temp.next;
            }
        }

    }
}