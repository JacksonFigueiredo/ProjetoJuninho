namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Nome = "Ademar";
            Console.WriteLine(produto.Nome);
        }
    }
}