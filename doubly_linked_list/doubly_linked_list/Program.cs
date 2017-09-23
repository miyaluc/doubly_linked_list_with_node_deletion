using System;

namespace doubly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Linked_List newList = new Linked_List(5);

            Console.WriteLine("");

            newList.AddFirst(1);
            newList.AddFirst(2);
            newList.AddLast(3);
            newList.AddFirst(4);
            newList.Remove(1);

            newList.ViewDoublyList();

            Console.WriteLine();

            Console.Read();
        }
    }
}
