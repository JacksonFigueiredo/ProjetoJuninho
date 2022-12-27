namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto produto = new Produto();

            produto.SetNome("Jackson");
            Console.WriteLine(produto.GetNome());
        }
    }
}