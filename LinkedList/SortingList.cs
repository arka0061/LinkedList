﻿using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T value)
        {
            data = value;
            next = null;
        }
    }
    class SortingList<T> where T : IComparable<T>
    {
        public Node<T> head = null;
        public Node<T> tail = null;
        public void AddNode(T data)
        {
            //Create a new node  
            Node<T> newNode = new Node<T>(data);

            //Checks if the list is empty  
            if (head == null)
            {
                //If list is empty, both head and tail will point to new node  
                head = newNode;
                tail = newNode;
            }
            else
            {
                //newNode will be added after tail such that tail's next will point to newNode  
                tail.next = newNode;
                //newNode will become new tail of the list  
                tail = newNode;
            }
        }
        public void SortOrderedList()
        {
            //Node current will point to head  
            Node<T> current = head, index = null;
            T temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;

                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        public void DisplaySort()
        {
            //Node current will point to head  
            Node<T> current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {
                //Prints each node by incrementing pointer  
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}