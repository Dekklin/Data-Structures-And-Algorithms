using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord
{
    public class HashSet
    {
        public string[] table { get; set; }

        public HashSet()
        {
            table = new string[1024];
        }

        public string RepeatedWord(string sentence)
        {
            
            string key = sentence.ToLower();
            string[] split = key.Split(" ");
            foreach(string str in split)
            {
                int finalValue = 0;
                byte[] ascii = Encoding.ASCII.GetBytes(str);
                foreach (byte b in ascii)
                {
                    finalValue += Convert.ToInt32(b);
                }
                finalValue = finalValue * 1024;
                finalValue = finalValue * str.Length;
                finalValue = finalValue / 1001 * str.Length;
                finalValue = finalValue % 999;
                if (table[finalValue] == null)
                {
                    table[finalValue] = str;
                }
                else if(table[finalValue] == str)
                {
                    return str;
                }
                else
                {
                    return $"Tried adding - {str} - into - {table[finalValue]} -";
                }
                
            }
            return "no dups";
        }
    }
}
