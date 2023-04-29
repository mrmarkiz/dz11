using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    public record StudentMarks
    {
        public int PE;
        public int Math;
        public int Economics;
        public int English;
        public double AVG { get { return (PE + Math + Economics + English) / 4.0; } }
        public StudentMarks(int pe, int math, int economics, int english)
        {
            PE = pe;
            Math = math;
            Economics = economics;
            English = english;
        }
        public StudentMarks()
        {
            PE = 0;
            Math = 0;
            English = 0;
            Economics = 0;
        }
        public StudentMarks(StudentMarks other)
        {
            this.PE = other.PE;
            this.Math = other.Math;
            this.Economics = other.Economics;
            this.English = other.English;
        }
    }

    internal class Task7
    {
        public static void Run()
        {
            StudentMarks[] marks = Init();
            Console.WriteLine("All students' marks:");
            Show(marks);
            Console.WriteLine("Best student's marks:");
            StudentMarks bestmarks = GetHighestAvg(marks);
            Show(bestmarks);
        }

        public static StudentMarks[] Init()
        {
            StudentMarks[] temp = new StudentMarks[5];
            Random rnd = new Random();
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i]=new StudentMarks(rnd.Next(2,6), rnd.Next(2,6), rnd.Next(2,6), rnd.Next(2,6));
            }
            return temp;
        }

        public static StudentMarks GetHighestAvg(StudentMarks[] marks)
        {
            StudentMarks result = marks[0];
            foreach(StudentMarks s in marks)
            {
                if (s.AVG > result.AVG)
                    result = s;
            }
            return new StudentMarks(result);
        }

        public static void Show(StudentMarks[] marks)
        {
            foreach (StudentMarks s in marks)
            {
                Console.WriteLine($"PE: {s.PE}");
                Console.WriteLine($"Math: {s.Math}");
                Console.WriteLine($"Economics: {s.Economics}");
                Console.WriteLine($"English: {s.English}\n");
            }
            Console.WriteLine('\n');
        }
        
        public static void Show(StudentMarks marks)
        {
            Console.WriteLine($"PE: {marks.PE}");
            Console.WriteLine($"Math: {marks.Math}");
            Console.WriteLine($"Economics: {marks.Economics}");
            Console.WriteLine($"English: {marks.English}");
            Console.WriteLine();
        }
    }
}
