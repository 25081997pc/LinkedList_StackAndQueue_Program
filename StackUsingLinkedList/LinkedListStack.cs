using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    internal class LinkedListStack
    {
        private Node top;
        
        public LinkedListStack()
        {
            this.top = null;
        }
        //This method is created to Pushing the Elements into Stack
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        //This method is created to Display the Stack Elemnets
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " "); //56 30 70 
                temp = temp.next;
            }
        }
        //This method is created to Show the top element of the stack
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }
        //This method is created to Popping the Stack Element
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        //This method is working till stack becomes empty.
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is Empty");
        }
    }
}
