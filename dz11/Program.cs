namespace dz11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter task to run: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Task1.Run();
                        break;
                    case 2:
                        Tasks2_4.Run2();
                        break;
                    case 3:
                        Tasks2_4.Run3();
                        break;
                    case 4:
                        Tasks2_4.Run4();
                        break;
                }
            } while (choice != 0);
        }
    }
}