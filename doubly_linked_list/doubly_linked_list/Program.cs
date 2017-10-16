using System;

namespace doubly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Linked_List doubly = new Linked_List(1);

            doubly.Add(2);
            doubly.Add(3);
            doubly.Add(4);
            doubly.Add(5);

            doubly.Remove(1);
            doubly.Print();

            Console.Read();


        }
    }
}
