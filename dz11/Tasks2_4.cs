using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace dz11
{
    public static class stringExtentions
    {
        public static int NumOfWords(this string text)
        {
            return text.Split(' ').Length;
        }

        public static int LastWordsLength(this string text)
        {
            return (text.Split('.', ',', ';', ':', ' ').Last(str => str != "").Length);
        }

        public static bool IsBracketsValid(this string text)
        {
            char ch;
            Stack<char> brackets = new Stack<char>(0);
            foreach (char c in text)
            {
                if (c == '(' || c == '[' || c == '{')
                    brackets.Push(c);
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (brackets.TryPeek(out ch))
                    {
                        if ((c == ')' && brackets.Peek() == '(') || (c == ']' && brackets.Peek() == '[') || (c == '}' && brackets.Peek() == '{'))
                            brackets.Pop();
                    }
                    else
                        return false;
                }
                        
            }
            return brackets.Count() == 0;
        }
    }

    internal class Tasks2_4
    {
        public static void Run2()
        {
            Console.WriteLine("Enter string to count words in:");
            string input = Console.ReadLine();
            Console.WriteLine($"Number of words: {input.NumOfWords()}");
        }

        public static void Run3()
        {
            Console.WriteLine("Enter string to count last word's length:");
            string input = Console.ReadLine();
            Console.WriteLine($"Length of last word: {input.LastWordsLength()}");
        }

        public static void Run4()
        {
            Console.WriteLine("Enter string to check on brackets validation:");
            string input = Console.ReadLine();
            Console.WriteLine($"Result: {input.IsBracketsValid()}");
        }
    }
}