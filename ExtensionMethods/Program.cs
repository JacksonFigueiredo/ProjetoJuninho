using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now.Subtract(TimeSpan.FromHours(1)).ElapsedTime());
        }
    }
}