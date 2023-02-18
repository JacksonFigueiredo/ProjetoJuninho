namespace Vetores
{
    internal class Program
    {
        /* Vetores são nomes dados a arranjos unidimensionais. - Array
         * Arranjo é uma estrutura de dados, sempre dados do mesmo tipo.
         * Fácil para acessar os dados, armazenado de uma só vez em im bloco contiguo de memória, ordenada sendo acessados por posição.
         * Desvantagem seria o tamanho fixo, e dificuldade para se realizar inserções e deleções.     
         * */

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n;i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma : " + vetor.Sum()); // Soma o vetor + Exibe com Contatenação.
            Console.WriteLine(String.Format("Soma : {0}",vetor.Sum())); // Soma o vetor + Exibe a String com Interpolação

            // Algumas Operações :

            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            //Obter a Média de forma 1
            Console.WriteLine(String.Format("A Média de Valores é : {0}", vetor.Sum() / n));
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedTicks;
            Console.WriteLine("Elapsed 1 : " + elapsedMs1);

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            //Ovter a Média de forma 2
            Console.WriteLine(String.Format("A Média de Valores é : {0}", vetor.Average()));
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedTicks;
            Console.WriteLine("Elapsed 2 : " + elapsedMs2);


        }
    }
}