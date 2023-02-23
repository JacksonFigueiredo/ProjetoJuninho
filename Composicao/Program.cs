using Composicao.Entities;

namespace Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Department");
            string deptName = Console.ReadLine();
            Console.WriteLine("Type Name");
            string name = Console.ReadLine();
            Console.WriteLine("Type Level");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Type Base Sallary");
            double baseSallary = double.Parse(Console.ReadLine());


            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSallary, department);

            Console.WriteLine("How Many Contracts do you Want??");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter {i} Contract Data");
                DateTime date = DateTime.Now;
                Console.WriteLine("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Value hours");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date,valuePerHour,hours);

                worker.AddContract(hourContract);

      
            }

            Console.WriteLine("Enter Month and Year MM/YYYY");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));
            Console.WriteLine(worker.Income(month, year));

        }
    }
}