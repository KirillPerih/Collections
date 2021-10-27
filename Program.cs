using System;
using System.Collections.Generic;
using System.IO;

namespace KOLLvar3
{
    class Program
    {
       
        static void Main(string[] args)
        { string a ;
            StreamReader sr = new StreamReader("D:/С#/21-22/KOLLvar3/bin/Debug/net5.0/koil.txt");
            a = sr.ReadToEnd();
            if(a == string.Empty)
            {
                Console.WriteLine("Файл пуст, заполните!");
            }
            else
            Console.WriteLine(a);
            Stack<char> stack = new Stack<char>();
            foreach (char c in a)
            {
                    if (c == '#')
                    {
                    if (stack.Count > 0)
                        stack.Pop();
                    }
                     else
                    {
                    stack.Push(c);
                    }
            }
            var array = stack.ToArray();
            Array.Reverse(array);
            string s = new string(array);
                Console.WriteLine(s);
        }
    }
}
