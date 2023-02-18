namespace Vetores
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Vetor de 1 Bilhão de Posições.
            long tamanhoVetor = 1000000000;
            Random numeroAleatorio = new Random();
            long[] vetor = new long[tamanhoVetor];
            double soma = 0;

            for (int i = 0; i < tamanhoVetor; i++)
            {
                // Gerar Aleatório de 100 Mil a 1 Bilhão.
                vetor[i] = numeroAleatorio.Next(1000000, 1000000000);
            }

            //Soma total da operação.
            Console.WriteLine(String.Format("Soma : {0} \n", vetor.Sum()));

            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(String.Format("A Média de Valores é : {0}", vetor.Sum() / tamanhoVetor));
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedTicks;
            var elapsedMs1ms = watch1.ElapsedMilliseconds;
            Console.WriteLine(String.Format("Corrido 3 : {0} Ticks e {1} Milissegundos\n", elapsedMs1, elapsedMs1ms));

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(String.Format("A Média de Valores é : {0}", vetor.Average()));
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedTicks;
            var elapsedMs2ms = watch2.ElapsedMilliseconds;
            Console.WriteLine(String.Format("Corrido 2 : {0} Ticks e {1} Milissegundos\n", elapsedMs2, elapsedMs2ms));

            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            foreach (double v in vetor)
            {
                soma += v;
            }
            Console.WriteLine(String.Format("A Média de Valores é : {0}", soma / tamanhoVetor));
            watch3.Stop();
            var elapsedMs3 = watch3.ElapsedTicks;
            var elapsedMs3ms = watch3.ElapsedMilliseconds;
            Console.WriteLine(String.Format("Corrido 3 : {0} Ticks e {1} Milissegundos\n", elapsedMs3, elapsedMs3ms));

        }
    }
}