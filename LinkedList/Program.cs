using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment!");
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(1, 30);
            list.PopLastElement();
            list.Display();         
            int check = list.Search(30);
            if(check==1)
            {
                Console.WriteLine("Element is Present");
            }
        }
    }
}