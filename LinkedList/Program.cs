using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment!");
            SortingList<int> sortinglist = new SortingList<int>();
            sortinglist.AddNode(56);
            sortinglist.AddNode(30);
            sortinglist.AddNode(40);
            sortinglist.AddNode(70);
            Console.WriteLine("original list: ");
            sortinglist.DisplaySort();
            sortinglist.SortOrderedList();
            Console.WriteLine("final sorted list: ");
            sortinglist.DisplaySort();





            //LinkedLists list = new LinkedLists();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //int check = list.Search(30);
            //if (check == 1)
            //{
            //    Console.WriteLine("Node is Present!");
            //    list.insertAtMid(40);
            //    list.Display();
            //}
            //else
            //{
            //    Console.WriteLine("Node is absent!");
            //}
            //list.DeleteNodeAtParticularPosition(2);
            // list.InsertAtParticularPosition(1, 30);
            // list.PopLastElement();


        }
    }
}