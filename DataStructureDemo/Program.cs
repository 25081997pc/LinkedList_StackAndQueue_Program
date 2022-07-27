namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The LinkedList Program");
            LinkedList list = new LinkedList();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.Display();

            list.Insert(30);
            Console.WriteLine("list is : ");
            list.Display();
        }
    }
}
