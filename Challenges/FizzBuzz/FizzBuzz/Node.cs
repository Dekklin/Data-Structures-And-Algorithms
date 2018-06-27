using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class Node
    {
        public Node Next { get; internal set; }
        public string Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(string value)
        {
            Value = value;
        }
}
}
