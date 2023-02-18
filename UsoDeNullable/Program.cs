namespace UsoDeNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = null; //Generic Type
            int? o = null; // Value Type


            Console.WriteLine(n.GetValueOrDefault()); // Se Nulo Sempre Retorne 0

            Console.WriteLine(o.GetValueOrDefault()); // Se Nulo Sempre Retorne 0

            if (o.HasValue && n.HasValue)
            {

            }

        }
    }
}