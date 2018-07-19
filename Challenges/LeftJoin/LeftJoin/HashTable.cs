using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeftJoin
{
    public class HashTable
    {
        public string[] table { get; set; }
        public List<string> keys { get; set; }

        public HashTable()
        {
            table = new string[1024];
            keys = new List<string>();

        }
        /// <summary>
        /// Takes a Key and a Value, both strings in this instance. 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Add(string key, string value)
        {
            keys.Add(key);
            int index = Hash(key);
            if(table[index] == null)
            {
                return table[index] = value;
            }
            return "null";
        }
        /// <summary>
        /// Grabs the hash'd value of the string I send it
        /// </summary>
        /// <param name="key">Which I grab the ASCII values and add them together, do math, and send it to my Add Method</param>
        /// <returns>And integer, which represents the index of that key</returns>
        public int Hash(string key)
        {
            int finalValue = 0;
            byte[] ascii = Encoding.ASCII.GetBytes(key);
            foreach (byte b in ascii)
            {
                finalValue += Convert.ToInt32(b);
            }
            finalValue = finalValue * 1024;
            finalValue = finalValue * key.Length;
            finalValue = finalValue / 1001 * key.Length;
            finalValue = finalValue % 1024;
            return finalValue;
        }
    }
}
