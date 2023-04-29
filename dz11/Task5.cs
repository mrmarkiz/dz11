using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class Task5
    {
        public static void Run()
        {
            int[] a = null;
            a = Init();
            Console.WriteLine("Original array:");
            Show(a);
            Console.WriteLine("Array after fitration:");
            a = a.Filtr(num => num % 2 == 0);
            Show(a);
        }

        private static int[] Init(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            return arr;
        }

        private static int[] Init()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            return arr;
        }

        private static void Show(int[] arr)
        {
            if (arr == null)
                return;
            foreach(int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
