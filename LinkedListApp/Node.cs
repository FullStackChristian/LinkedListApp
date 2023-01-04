namespace LinkedListApp
{
    public class Node
    {
        public string Name { get; set; }
        public Node next;  
        public Node(string name)
        {
            Name = name;
            next = null;
        }
        
    }
}
