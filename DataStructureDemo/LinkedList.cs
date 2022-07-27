using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class LinkedList
    {
        internal Node head;
        //This method is created to adding the elements into the LinkedList
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        //This method is created to Display the LinkedList 
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //This method created to Appending Values
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                node.next = temp;
            }
        }
        //This method created to Inserting 30 between 56 and 70
        internal void Insert(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
                this.head = node;
            else
            {
                var temp = this.head;
                var middle = this.head;
                //find the middle node
                while (temp.next != null && temp.next.next != null)
                {
                    temp = temp.next.next;
                    middle = middle.next;
                }
                //add node
                node.next = middle.next;
                middle.next = node;
            }
        }
        //This method created to Delete First Element of Linked List
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        //This method is created to Delete Last Element of Linked List
        internal Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        //This method is created to Searching Value 
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
        internal void insertAtPosition(int newElement, int positon)
        {
            Node newNode = new Node();
            newNode.data = newElement;
            newNode.next = null;
            if (positon < 1)
            {
                Console.WriteLine("\nposition should be >= 1.");
            }
            else if (positon == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                for (int i = 1; i < positon - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.WriteLine("\nprevious node is null");
                }
            }
        }
        internal void Delete_atPosition(int position)
        {
            if (position < 1)
            {
                Console.WriteLine("\nposition should be >= 1.");
            }
            else if (position == 1 && head != null)
            {
                Node nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    Node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.WriteLine("\nThe node is already null");
                }
            }
        }
    }
}