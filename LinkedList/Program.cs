﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Assignment!");
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int check = list.Search(30);
            if (check == 1)
            {
                Console.WriteLine("Node is Present!");
                list.insertAtMid(40);
                list.Display();
            }
            else
            {
                Console.WriteLine("Node is absent!");
            }





            // list.InsertAtParticularPosition(1, 30);
            // list.PopLastElement();
                   

        }
    }
}