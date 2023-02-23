namespace Ternarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int preco = 10000;
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
        }
    }
}