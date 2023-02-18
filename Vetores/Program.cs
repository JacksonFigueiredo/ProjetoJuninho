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
            int tamanhoVetor = 1000000000;
            Random numeroAleatorio = new Random();
            double[] vetor = new double[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetor[i] = numeroAleatorio.Next(1,50000000);
            }

            Console.WriteLine(String.Format("Soma : {0}",vetor.Sum()));


            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(String.Format("A Média de Valores é : {0} ", vetor.Sum() / tamanhoVetor));
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            Console.WriteLine("Elapsed 1 : " + elapsedMs1 + " Milisegundos");

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(String.Format("A Média de Valores é : {0} Milisegundos", vetor.Average()));
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine("Elapsed 2 : " + elapsedMs2 + " Milisegundos");


        }
    }
}