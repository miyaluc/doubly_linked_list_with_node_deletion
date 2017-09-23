using System;
using System.Collections.Generic;
using System.Text;

namespace doubly_linked_list
{
    class Linked_List
    {
        public Node Next
        {
            get; set;
        }
        public Linked_List(int data)
        {
            Next = new Node(data);
        }
        public void AddLast(int data)
        {
            Node runner = Next;

            while(runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = new Node(data);
            runner.Next.Previous = runner;
        }

        public void ViewDoublyList()
        {
            //need to work on view method
        }
        public void AddFirst(int data)
        {
            Node current = Next;
            Next = new Node(data);
            Next.Next = current;
            current.Previous = Next;
        }

        public Node RemoveFirst()
        {
            Node current = Next;
            Next.Previous = null;
            current.Next = null;
            return current;
        }

        public Node Remove(int data)
        {
            Node runner = Next;
            if(runner.Data == data)
            {
                return RemoveFirst();
            }
            else
            {
                while (runner.Next != null && runner.Data != data)
                {
                    runner = runner.Next;
                }
                if(runner.Data != data)
                {
                    Console.WriteLine("Didn't find data.");
                    return;
                }
                else
                {
                    runner.Previous.Next = runner.Next;
                    runner.Next.Previous = runner.Previous;
                    runner.Next = null;
                    runner.Previous = null;
                    return runner;
                }
            }
        }
    }
}
