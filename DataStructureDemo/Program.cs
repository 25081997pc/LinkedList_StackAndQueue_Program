namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The LinkedList Program");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("---------------");
            
            list.insertAtPosition(40,3);
            Console.WriteLine("Linked List is : ");
            list.Display();
            Console.WriteLine("---------------");

            list.Delete_atPosition(3);
            Console.WriteLine("Linked List is : ");
            list.Display();
            Console.ReadKey();
        }
    }
}
