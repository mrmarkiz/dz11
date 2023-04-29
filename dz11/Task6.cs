using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class Task6
    {
        public static void Run()
        {
            DayTemp[] week = Init(7);
            Console.WriteLine("Week temperatures:");
            Show(week);
            DayTemp maxAmp = FindMaxAmplitude(week);
            Console.WriteLine("Max amplitude day temperatures:");
            Console.WriteLine($"Max: {maxAmp.MaxTemp}  Min: {maxAmp.MinTemp}");
        }

        public static DayTemp FindMaxAmplitude(DayTemp[] days)
        {
            DayTemp result = days[0];
            foreach(DayTemp day in days)
            {
                if (day.MaxTemp - day.MinTemp > result.MaxTemp - result.MinTemp)
                    result = day;
            }
            return new DayTemp(result);
        }

        public static DayTemp[] Init(int n)
        {
            DayTemp[] temp = new DayTemp[n];
            Random rnd = new Random();
            for (int i = 0; i < temp.Length; i++)
                temp[i] = new DayTemp(rnd.Next(-5, 5), rnd.Next(6, 15));
            return temp;
        }
        public static DayTemp[] Init()
        {
            DayTemp[] temp = new DayTemp[5];
            Random rnd = new Random();
            for (int i = 0; i < temp.Length; i++)
                temp[i] = new DayTemp(rnd.Next(-5, 5), rnd.Next(6, 15));
            return temp;
        }

        public static void Show(DayTemp[] arr)
        {
            foreach(DayTemp day in arr)
            {
                Console.WriteLine($"Max: {day.MaxTemp}  Min: {day.MinTemp}");
            }
            Console.WriteLine();
        }
    }

    public record DayTemp
    {
        public int MinTemp;
        public int MaxTemp;
        public DayTemp(int min, int max)
        {
            MinTemp = min;
            MaxTemp = max;
        }
        public DayTemp(DayTemp other)
        {
            this.MaxTemp = other.MaxTemp;
            this.MinTemp = other.MinTemp;
        }
    }
}
