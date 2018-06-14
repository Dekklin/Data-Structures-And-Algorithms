﻿using System;

namespace ll_merge.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }
        
        public Node Current { get; set; }

        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }
        //adding a node at the head O(1)
        public void AddNode(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }
        //find a node with the value of *value* O(n) 
        public Node Find(int value)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if(Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }

        //Print out all nodes O(n)
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
        // Add before the exist node
        public void AddBefore(Node newNode, Node exist)
        {
            Current = Head;
            
            while(Current.Next != null)
            {
                if (Current.Next.Value == exist.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }

        }
        // add after the search key which is refered to as exist
        public void AddAfter(Node newNode, Node exist)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if (Current.Value == exist.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
            // You are at the end of your list
            if (Current.Value == exist.Value)
            {
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }

        }
        // add last O(n) meaning adding a node to the end
        public void AddLast(Node newNode)
        {
            Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

    }
}
