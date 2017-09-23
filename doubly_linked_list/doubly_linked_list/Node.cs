using System;
using System.Collections.Generic;
using System.Text;

namespace doubly_linked_list
{
    class Node
    {
        public int Data
        {
            get; set;
        }
        public Node Previous
        {
            get; set;
        }
        public Node Next
        {
            get; set;
        }
        public Node(int data)
        {
            Data = data;
        }
    }
}
