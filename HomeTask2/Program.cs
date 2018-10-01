using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Program
    {
        static string rep(string s2, string[] b)
        {
            for (int i = 0; i < b.Length; i++)
                s2 = s2.Replace(b[0], "");
            return s2;
        }
        static void func1()
        {
            Console.Write("Enter two strings to see if one of them contains another:\ns1:=\t");
            string s1 = Console.ReadLine();
            Console.Write("s2:=\t");
            string s2 = Console.ReadLine();
            if (s1.Length > s2.Length)
            {
                string s3 = s1;
                s1 = s2;
                s2 = s1;
            }
            Console.WriteLine("Does '{0}' contain '{1}'?", s2, s1);
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            Console.WriteLine("    {0}", s1.Contains(s2));
        }
        static void func2()
        {
            Console.Write("Enter string to see if it is a polinom:\ns1:=\t");
            string s1 = Console.ReadLine();
            string s2 = s1.ToLower();
            string[] b = { " ", "/", ".", ",", "!", "?" };
            s2 = rep(s2, b);
            Console.WriteLine("Is '{0}' a polinom? ", s1);
            for (int i = 0; i < s2.Length / 2; i++)
                if (s2[i] != s2[s2.Length - i - 1])
                {
                    Console.WriteLine("    False");
                    return;
                }
            Console.WriteLine("    True");
        }
        static void func3()
        {
            string s = Console.ReadLine();
            string s1 = s.Replace(",", "");
            string[] textMass = s1.Split('.', '!', '?');
            int count = 0, max = 0, count1 = 0, y = 0;
            for (int i = 0; i < textMass.Length; i++)
            {
                y += (textMass[i].Length + 1);
                int k = textMass[i].Split(' ').Length;
                if (max < k)
                {
                    max = k;
                    count = i;
                    count1 = y;
                }
            }
            Console.WriteLine("The sentence with the greatest number of words:");
            Console.WriteLine(textMass[count] + s[count1 - 1]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("There are 3 functions:\n1) check on entry\n2) check on a polynomial");
            Console.WriteLine("3) find sentence with the greatest number of words");
            Console.Write("To exit enter '0'\nWich would you like to use?(1-3)\n");
            try
            {
                int c1;
                do
                {
                    string str = Console.ReadLine();
                    if (!Int32.TryParse(str, out c1))
                    {
                        continue;
                    }
                } while (c1 < 0 && c1 > 3);
                switch (c1)
                {
                    case 1:
                        func1();
                        break;
                    case 2:
                        func2();
                        break;
                    case 3:
                        func3();
                        break;
                    default:
                        break;
                }
            }
            catch { Console.WriteLine("Error"); }
            Console.ReadKey();
        }
    }
}