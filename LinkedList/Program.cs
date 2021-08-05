using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node(56);
            Node nodeB = new Node(30);
            Node nodeC = new Node(70);
            nodeA.next = nodeB;
            nodeB.next = nodeC;
        }
    }
}
