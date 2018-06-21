using System;

namespace MultiBracket
{
    public class Program
    {
        //main method that calls my MultiBracketValidation method with a string
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MultiBracketValidation("}He(llo{Wo}rl)d"));
            Console.ReadKey();
        }
        //tests string parameter to see if there is symetrical bracket implementation throughout the string
        public static bool MultiBracketValidation(string s)
        {
            int count = 0;
            char[] arr = new char[10];
            foreach(char c in s)
            {
                try
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        arr[count] = c;
                        count++;
                    }
                    if (c == ')' && arr[count - 1] == '(')
                        count--;
                    if (c == ']' && arr[count - 1] == '[')
                        count--;
                    if (c == '}' && arr[count - 1] == '{')
                        count--;
                }
                catch (IndexOutOfRangeException e)
                {
                    return false;
                }
            }
            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}