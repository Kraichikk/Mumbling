using System;

namespace Mumbling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("abcd"));
        }
        public static String Accum(string b)
        {
            string s = b.ToLower();

            string val = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = -1; j < i; j++)
                {
                    if (i == 0)
                    {
                        val += s[i].ToString().ToUpper();
                    }
                    if (i > 0)
                    {
                        if (j == -1)
                        {
                            val += s[i].ToString().ToUpper();
                        }
                        else
                        {
                            val += s[i];
                        }
                    }
                }
                if (i != s.Length - 1)
                    val += "-";
            }
            return val;
        }
    }
}
