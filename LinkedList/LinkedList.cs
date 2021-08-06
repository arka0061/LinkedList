using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedLists
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public Node Pop()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        public Node PopLastElement()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {

                if (node.data == value)
                {
                     count++;
                     break;
                }
                node = node.next;
                
            }
            return count;
          
        }
        public void insertAtMid(int value)
        {
            // if list is empty
            if (head == null)
                head = new Node(value);
            else
            {
                // get a new node
                Node newNode = new Node(value);
                Node ptr = head;
                int len = 0;
                // calculate length of the linked list
                //, i.e, the number of nodes
                while (ptr != null)
                {
                    len++;
                    ptr = ptr.next;
                }
                // 'count' the number of nodes after which
                // the new node is to be inserted
                int count = ((len % 2) == 0) ? (len / 2) :
                                            (len + 1) / 2;
                ptr = head;

                // 'ptr' points to the node after which
                // the new node is to be inserted
                while (count-- > 1)
                    ptr = ptr.next;

                // insert the 'newNode' and adjust
                // the required links
                newNode.next = ptr.next;
                ptr.next = newNode;
            }
        }
        public void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkedList is :-" + " " + count);
        }


    }
}


