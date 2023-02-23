namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool teste = true;

            switch (teste)
            {
                case true:
                    Console.WriteLine("Teste True");
                    Console.WriteLine("Ok");
                    break;
                case false:
                    Console.WriteLine("Teste Faulse");
                    Console.WriteLine("Ok");
                    break;


                default:
                    Console.WriteLine("Nada");
                    break;
            }
        }
    }
}