namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;

            Object obj = x; // Boxing - Jogando para o Heap

            Console.WriteLine(obj);

            int y = (int)obj; // Trazebdi do Heap.

            Console.WriteLine(y);


        }
    }
}