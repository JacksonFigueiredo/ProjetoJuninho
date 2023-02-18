namespace Vetores
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Vetor de 1 Milhão de Posições.
            int tamanhoVetor = 1000000;
            Random numeroAleatorio = new Random();
            double[] vetor = new double[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                // Gerar Aleatório de 1 a 10 Milhões.
                vetor[i] = numeroAleatorio.Next(1, 10000000);
            }

            //Soma total da operação.
            Console.WriteLine(String.Format("Soma : {0} \n", vetor.Sum()));


            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(String.Format("A Média de Valores é : {0}", vetor.Sum() / tamanhoVetor));
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedTicks;
            Console.WriteLine("Corrido 1 : " + elapsedMs1 + " Ticks - Método Soma / Tamanho \n");

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(String.Format("A Média de Valores é : {0}", vetor.Average()));
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedTicks;
            Console.WriteLine("Corrido 2 : " + elapsedMs2 + " Ticks - Método Média do Framework \n");

            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            double soma = 0;
            foreach (double v in vetor)
            {
                soma += v;
            }
            Console.WriteLine(String.Format("A Média de Valores é : {0}", soma / tamanhoVetor));
            watch3.Stop();
            var elapsedMs3 = watch3.ElapsedTicks;
            Console.WriteLine("Corrido 3 : " + elapsedMs3 + " Ticks - Método Foreach");

        }
    }
}