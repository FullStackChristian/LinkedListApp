using System;
using System.Threading;

namespace LinkedListApp
{
    internal class LinkedNodeList
    {
        // head node in the list
        private Node head;
        public Node Head { get { return head; } set { head = value; } }
        
        public LinkedNodeList()
        {
            head = null;
        }

        /// <summary>
        /// Add to the end of the list
        /// </summary>
        /// <param name="name"></param>
        public void AddNode(string name)
        {
            if (head == null)
            {
                head = new Node(name);
                return;
            }

            Node current = head;
            while(current.next != null)
            {
                current = current.next;
            }

            current.next = new Node(name);
        }

        /// <summary>
        /// Add as new Head
        /// </summary>
        /// <param name="name"></param>
        public void PrependNode(string name)
        {
            Node newHead = new Node(name);
            newHead.next = head;
            head = newHead;
        }

        /// <summary>
        /// Add node with a name at a specific position
        /// </summary>
        /// <param name="name"></param>
        /// <param name="position"></param>
        public void AddNodeAtPosition(string name, int position)
        {
            Node node = new Node(name);
            Node current = head;

            if (position == 0)
            {
                PrependNode(name);
                return;
            }

            if (head != null)
            {
                for (int i = 0; i < position - 1; i++)
                {
                    current = current.next;
                }
                node.next = current.next;
                current.next = node;
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
                Node current = head;
                while (current != null)
                {
                    if (position == 0)
                    {
                        head = current.next;
                        return;
                    }

                    for (int i = 0; i < position - 1; i++)
                    {
                        current = current.next;
                    }

                    current.next = current.next.next;
                    return;
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
                    Console.WriteLine($"Name: {scaner.Name}");
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
