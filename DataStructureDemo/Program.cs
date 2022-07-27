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

            LinkedList linked = new LinkedList();
            linked.Append(56);
            linked.Append(30);
            linked.Append(70);
            Console.WriteLine("====================");
            Console.WriteLine("Appending 30 and 70 to 56 in LinkedList is: ");
            linked.Display();
            Console.ReadKey();
        }
    }
}
