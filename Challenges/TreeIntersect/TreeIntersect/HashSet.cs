using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersect
{
    public class HashSet
    {
        /// <summary>
        /// Hashset constructor and sets the length to 1024
        /// </summary>
        public int[] table { get; set; }
        public HashSet()
        {
            table = new int[1024];
            repeats = new List<int>();
        }
        public List<int> repeats { get; set; }
        /// <summary>
        /// Splits up a string by words, then passes each word through a Hashing algorithm, if we run into a collision, then the words are a duplicate
        /// </summary>
        /// <param name="sentence">Takes in an integer (value from PreOrder), hashes it, and then add's it to the HashSet</param>
        /// <returns>Nothing is returned, but the repeat List is affected.</returns>
        public void AddNumbers(int key)
        {
            string j = key.ToString();
                int finalValue = 0;
                byte[] ascii = Encoding.ASCII.GetBytes(j);
                foreach (byte b in ascii)
                {
                    finalValue += Convert.ToInt32(b);
                }
            finalValue = finalValue * 425;
            finalValue = finalValue / 123;
            finalValue = finalValue * 1421;
                finalValue = finalValue % 1024;
                int k = Convert.ToInt32(j);
            if(table[finalValue] != 0)
            {
                repeats.Add(key);
            }
            else
            {
            table[finalValue] = key;
            }
            }
        }
    
    }
