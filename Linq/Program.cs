namespace Linq
{
    public class Program
    {

    

        static void Main(string[] args)
        {                       
            int[] pairNumbers = { 1, 2, 3, 4, 5, };
            List<int> evenNumbers = pairNumbers.Where(n => n % 2 == 0).ToList();
          
            foreach (int n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }

    }
}