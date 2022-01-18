using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    internal class Node
    {
        public string Name { get; set; }
        public int position;
        public Node next;  
        public Node(string name)
        {
            Name = name;
            position = 0;
            next = null;
        }
        
    }
}
