﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementGraph
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Child { get; set; }
        public bool Visited { get; set; } = false;

        public Node(int value)
        {
            Value = value;
            Child = new List<Node>();
        }
    }
}
