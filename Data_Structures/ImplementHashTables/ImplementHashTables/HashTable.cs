using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementHashTables
{
    public class HashTable
    {
        public List<KeyValuePair<string, int>>[] table { get; set; }

        public HashTable()
        {
            table = new List<KeyValuePair<string, int>>[1024];
        }

        public void Add(string key, int value)
        {
            int finalValue = 0;
            byte[] ascii = Encoding.ASCII.GetBytes(key);
            foreach (byte b in ascii)
            {
                finalValue += Convert.ToInt32(b);
            }
            finalValue = finalValue * 1024;
            finalValue = finalValue * key.Length;
            finalValue = finalValue / 1001*key.Length;
            if (finalValue > 1024)
                finalValue = finalValue / 552;
            KeyValuePair<string, int> kvp = new KeyValuePair<string, int>(key, value);
            if (table[finalValue] == null)
                table[finalValue] = new List<KeyValuePair<string, int>>();
            table[finalValue].Add(kvp);

        }
        public int Find(string key)
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
            if (finalValue > 1024)
                finalValue = finalValue / 552;
            KeyValuePair<string, int> x = table[finalValue].FirstOrDefault(kvp => kvp.Key == key);
            return x.Value;
        }

        public bool Contains(string key)
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
            if (finalValue > 1024)
                finalValue = finalValue / 552;
            var result = table[finalValue].Select(kvp => kvp.Key == key);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        public int GetHash(string key)
        {
            int finalValue = 0;
            byte[] ascii = Encoding.ASCII.GetBytes(key);
            foreach (byte b in ascii)
            {
                finalValue += Convert.ToInt32(b);
            }
            return finalValue;
        }
    }
}
