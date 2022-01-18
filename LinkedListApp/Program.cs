using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedNodeList list = new LinkedNodeList();
            list.AddNode("E");
            Console.WriteLine("\nPrint NodeList\n");
            list.PrintList();
            Console.WriteLine($"\nYou currently have {list.Count} Node(s) in your list.");
            Console.WriteLine("\nDeleting node from list:\n");
            list.DeleteNodeAtPosition(0);

            list.PrintList();
            Console.WriteLine($"\nYou currently have {list.Count} Node(s) in your list.");
            Console.WriteLine("\nAdding new node to list:\n");
            list.AddNodeAtPosition("Z", 0);
            list.PrintList();

            //Console.WriteLine("\nPrint Node at position 2:\n");
            //list.PrintNodeAtPosition(1);
            Console.WriteLine($"\nYou currently have {list.Count} Node(s) in your list.");
            
            Console.ReadKey();
        }
    }
}
