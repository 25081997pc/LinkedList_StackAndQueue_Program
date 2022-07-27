﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    public class LinkedListQueue
    {
        Node head = null;
        //This method is created to Enqueue the elements into Queue 
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        //This method is created to Display the Queue
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //This method is created to Dequeue the element of Queue
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("The Dequeue element is : " + head.data);
                head = head.next;
            }
        }
    }
}
