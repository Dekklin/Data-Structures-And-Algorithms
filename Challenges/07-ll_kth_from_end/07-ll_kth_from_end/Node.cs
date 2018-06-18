using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ll_kth_from_end
{
    //node constructor
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }
}
