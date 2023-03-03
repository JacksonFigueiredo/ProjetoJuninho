namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Pessoa> hashset = new HashSet<Pessoa>();

            hashset.Add(new Pessoa { NomePessoa = "Jackson", Idade = 32 });
            hashset.Add(new Pessoa { NomePessoa = "Kaylla", Idade = 5 });
            hashset.Add(new Pessoa { NomePessoa = "Ketlen", Idade = 31 });


            int soma = 0;
            foreach (var p in hashset)
            {
                soma += p.Idade;
            }

            Console.WriteLine("A Idade de todos é {0}",soma);

        }
    }
}