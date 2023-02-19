namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            int[,] matrix = new int[n, n];


            for (int i = 0; i < n;i++ )
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0 ; j < n; j++)
                {
                    matrix[i,j] = int.Parse(values[j]);
                }
            }

            for (int i =0 ; i < n; i++)
            {
                Console.WriteLine(matrix[i,i] + " "); // inicia lendo 0 , 1 , 2 
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j =0 ; j < n; j++)
                {
                    if (matrix[i,7+j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}