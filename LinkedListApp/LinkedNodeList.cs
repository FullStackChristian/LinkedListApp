using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    internal class LinkedNodeList
    {
        // head node in the list
        private Node head;
        public Node Head { get { return head; } set { head = value; } }
        private int count;
        public int Count { get { return count; } }
        public LinkedNodeList()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Add node with a name and at a specific position
        /// </summary>
        /// <param name="name"></param>
        /// <param name="position"></param>
        public void AddNodeAtPosition(string name, int position)
        {
            Node node = new Node(name);
            Node scaner = head;
            if (head != null)
            {
                while (scaner != null)
                {
                    if (scaner.position == position)
                    {
                        //Add the new node to the current scaners position
                        node.next = scaner.next;
                        node.position = position;
                        //move the current nodes position up
                        scaner.position = position + 1;
                        scaner.next = node;
                        //Make the scaner the next node and then exit the loop
                        scaner = node.next;
                        count++;
                        break;
                    }
                    //Add position + 1 till the scaner reaches the wanted position
                    scaner.position++;
                    //Move the scaner to the next node
                    scaner = scaner.next;
                }
            }
            else
            {
                node.next = head;
                node.position = count;
                head = node;
                count++;
            }
        }
        /// <summary>
        /// Delete node at a specific position
        /// </summary>
        /// <param name="position"></param>
        public void DeleteNodeAtPosition(int position)
        {
            if (head != null)
            {
                Node scaner = head;
                while (scaner != null)
                {
                    //if having to remove head node:
                    if (scaner.position == position)
                    {
                        head = scaner.next;
                        count--;
                        break;
                    }
                    //if havong to remove any other node
                    if (scaner.position == position + 1)
                    {
                        scaner.next = scaner.next.next;
                        scaner.position--;
                        count--;
                        break;
                    }
                    scaner.position--;
                    scaner = scaner.next;
                }
            }
            else
            {
                Console.WriteLine("Nothing to delete");
            }
        }
        /// <summary>
        /// Print all nodes
        /// </summary>
        public void PrintList()
        {
            if (head != null)
            {
                //create a scaner Node to run over existing nodes and rint their data
                Node scaner = head;
                while (scaner != null)
                {
                    Console.WriteLine($"Name: {scaner.Name} Position: {scaner.position}");
                    scaner = scaner.next;
                }
            }
            else
            {
                Console.WriteLine("Nothing to display");
            }
        }
        /// <summary>
        /// Print node at given position
        /// </summary>
        /// <param name="position"></param>
        public void PrintNodeAtPosition(int position)
        {
            if (head != null)
            {
                Node scaner = head;
                while (scaner != null)
                {
                    if (scaner.position == position)
                    {
                        Console.WriteLine(scaner.Name);
                    }
                    scaner = scaner.next;
                }
            }
            else 
            {
                Console.WriteLine("Nothing to display");
            }
        }
    }
}
