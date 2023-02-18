namespace Listas
{
    internal class Program
    {
        // Elementos são adicionados sob demanda, cada elemento ocupa um nós, deriva na System.Collections.Generic
        // Desvantagem por ser acesso sequencial aos elementos e fácil para manipular.
        // Uma lista geralmente tem internamente o seu valor armazenado e o ponteiro do proximo nodo na lista.
        // Demora muito na hora de pesquisar elemento porque vai na ordem.


        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Insert(0, "Bolsonaro"); // Entra primeiro, index tá 0
            list.Add("Ciro");
            list.Add("Lula");
            list.Add("Tablet");

            foreach (string item in list)
            {
                // Console.WriteLine(String.Format("{0}",item)); 
                // caso ao inves de string for var, terá que usar o stirng format.
                Console.WriteLine(item);

            }

            Console.WriteLine(list.Find(x => x == "Bolsonaro")); // Procura na lista toda a palavra que corresponda com a busca.
            Console.WriteLine(list.Find(x => x[1] == 'B')); // Procura na lista toda a palavra que corresponda com a primeira letra (B) tá buscando pelo CHAR no IndexB


        }
    }
}