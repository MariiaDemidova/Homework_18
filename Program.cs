using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку состоящую из скобок");
            string sentence = Convert.ToString(Console.ReadLine());
            char[] charray = sentence.ToCharArray();
            Stack<char> chstack = new Stack<char>();
            foreach (char c in charray)
            {
                if (c == '(')
                {
                    chstack.Push(')');
                }
                else if (c == '[')
                {
                    chstack.Push(']');
                }
                else if (c == '{')
                {
                    chstack.Push('}');
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (chstack.Count == 0)
                    {
                        Console.WriteLine("Скобки расставлены неправильно");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        if (c == chstack.Peek())
                        {
                            chstack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Скобки расставлены неправильно");
                            Console.ReadKey();
                            return;
                        }
                    }
                }
                }
            Console.WriteLine("Скобки расставлены правильно");
            Console.ReadKey();
        }
    }
}
