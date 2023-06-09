﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    public static class intExtensions
    {
        public static bool IsFibonacci(this int number)
        {
            int a = 0, b = 1, c = 1, tmp;
            while (a < number)
            {
                tmp = b + c;
                a = b;
                b = c;
                c = tmp;
            }
            return number == a;
        }

        public static int[] Filtr(this int[] array, Func<int, bool> f)
        {
            if (array == null)
                return null;
            int[] result = new int[0];
            foreach (int i 
                in array)
            {
                if (f(i))
                    result = result.Append(i).ToArray();
            }
            return result;
        }
    }

    internal class Task1
    {
        public static void Run()
        {
            Console.Write("Enter number to check on being Fibonacci's: ");
            if (int.TryParse(Console.ReadLine(), out int number))
                Console.WriteLine($"Result: {number.IsFibonacci()}");
            else
                Console.WriteLine("Wrong number!");
        }
    }
}
