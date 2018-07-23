using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable hs = new HashTable();
            hs.Add("fond", "enamored");
            hs.Add("wrath", "anger");
            hs.Add("diligent", "employed");
            hs.Add("outfit", "garb");
            hs.Add("guide", "usher");


            HashTable hs2 = new HashTable();
            hs2.Add("fond", "adverse");
            hs2.Add("wrath", "delight");
            hs2.Add("diligent", "idle");
            hs2.Add("guide", "follow");
            hs2.Add("flow", "jam");

            List<string> k = JoinLeft(hs, hs2);
            foreach(string i in k)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
        /// <summary>
        /// JoinLeft takes two HashTables, and combines the second HS, and checks if there are any similar keys, if there are they add their values to a list, if theres a key in HashTable1, then we add Null at the end of the value and add it to the list
        /// </summary>
        /// <param name="hs">Hashtable 1, our base</param>
        /// <param name="hs2">Hashtable 2, what we compare to Hashtable 1</param>
        /// <returns>List of strings, a concatonated string of similar keys and their values</returns>
        public static List<string> JoinLeft(HashTable hs, HashTable hs2)
        {
            List<string> datList = new List<string>();
            foreach (string key in hs.keys)
            {
                datList.Add($"{key} : {hs.table[hs.Hash(key)]}");
            }
            foreach (string key in hs2.keys)
            {
                for (int i = 0; i < hs2.keys.Count; i++)
                {
                    if (key == hs.keys[i])
                    {
                        datList[i] = $"{datList[i]} & {hs2.table[hs2.Hash(key)]}";
                        break;
                    }
                }
            }
            for (int i = 0; i < hs.keys.Count; i++)
            {
                if (!hs2.keys.Contains(hs.keys[i]))
                {
                    datList[i] = $"{datList[i]} & Null";
                }
            }
            return datList;
        }
    }
}
