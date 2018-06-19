using System;
using System.Collections.Generic;
using System.Text;

namespace _12_AnimalShelter
{
    public class AnimalShelter
    {
        public Animal Rear { get; set; }
        public Animal Front { get; set; }

        // queue constructor
        public AnimalShelter(Animal node)
        {
            Front = node;
            Rear = node;
        }
        // Adds a node to the queue
        public string EnQueue(Animal node)
        {
            node.Value = node.Value.ToLower();
            if (node.Value == "dog" || node.Value == "cat")
            {
                Rear.Next = node;
                Rear = node;
                return Rear.Value;
            }
            return "Please pick dog or cat";
        }
        // removes the next in line Node from the queue
        public Animal DeQueue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
            
        }
        public Animal DeQueue(string pref)
        {
            pref = pref.ToLower();
            if (pref != "cat" && pref != "dog")
                return DeQueue();
            Animal temp = Front;
            while(temp.Next != null)
            {
                if(temp.Next.Value == pref)
                {
                    Animal temp2 = temp.Next;
                    temp.Next = temp.Next.Next;
                    temp2.Next = null;
                    return temp2;
                }
                temp = temp.Next;
            }
            return DeQueue();
        }
        // returns the next in line node from the queue
        public Animal Peek()
        {
            return Front;
        }
        // prints all the nodes in the queue
        public void Print()
        {
            Animal Current = Front;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
    }
}
