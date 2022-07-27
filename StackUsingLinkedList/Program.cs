
namespace StackUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Stack Program where we using Stack Operations");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);

            linkedListStack.Display();
            Console.ReadKey();
        }
    }
}

