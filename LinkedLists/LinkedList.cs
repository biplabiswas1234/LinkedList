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
        public void Append(int data)
        {
            //create new node
            Node node = new Node(data);
            //check if list is empty then node becomes as head
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                //if not then put head in temp variable
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Added node to the LinkedList : " + data);
        }
        public bool Search(int data)
        {
            //temp variable is head now
            Node temp = this.head;
            //check until temp location will null
            while (temp != null)
            {
                //if temp node data is equal to value to be searched
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
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