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
            Console.WriteLine("\nSearch for Node 30");
            if (list.Search(30))
            {
                Console.WriteLine("Node Found");
            }
            else
            {
                Console.WriteLine("\nNode doesn't exists");
            }
            list.Display();
            Console.WriteLine("\nInsert a node 40.");
            list.AddNodeAfterNode(40, 30);
            list.Display();
            Console.WriteLine("\nSearch for Node 40");
            if (list.Search(40))
            {
                Console.WriteLine("Node Found");
            }
            else
            {
                Console.WriteLine("\nNode doesn't exists");
            }
            Console.WriteLine("Remove Node 40");
            list.DeleteSpecificNode();
            list.Display();
        }
    }
}