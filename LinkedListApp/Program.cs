using System;

namespace LinkedListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedNodeList list = new LinkedNodeList();
            list.AddNode("E");
            list.AddNode("C");
            list.AddNode("D");
            Console.WriteLine("\nPrint NodeList\n");
            list.PrintList();

            list.AddNodeAtPosition("A", 1);

            Console.WriteLine("\nPrint NodeList\n");
            list.PrintList();

            list.DeleteNodeAtPosition(2);

            Console.WriteLine("\nPrint NodeList\n");
            list.PrintList();

            Console.ReadKey();
        }
    }
}
