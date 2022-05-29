using System;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList list = new LinkedList();
            Console.WriteLine("Append the list");
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}
