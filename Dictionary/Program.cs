namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionaryes somente aceitam 1 valor como chave unico.
            // trabalham baseado em chave / valor
            // Chega no Elemento Baseado na chave.

            // Problema Proposto:
            /* Você irá desenvolver um sistema de votação, serão recebidos alguns candidatos, esses candidatos irão ser fornecidos em uma Entidade.
             * Logo em seguida você irá criar um dictionary e irá mostrar quem recebeu mais votos*/

            Dictionary<string, int> totalizacao = new Dictionary<string, int>();
            List<Candidato> candidatos = new List<Candidato>();

            candidatos.Add(new Candidato { Nome = "Jackson", Urna = 1, Votos = 10 });
            candidatos.Add(new Candidato { Nome = "Sereia", Urna = 1, Votos = 1000 });
            candidatos.Add(new Candidato("Jackson", 10, 2));

            foreach (var item in candidatos)
            {
                if (totalizacao.ContainsKey(item.Nome))
                {
                    totalizacao[item.Nome] += item.Votos;
                }
                else
                {
                    totalizacao[item.Nome] = item.Votos;
                }
            }

            Console.WriteLine("O Vencedor é a {0} com {1} votos",totalizacao.OrderByDescending(x => x.Value).First().Key, totalizacao.OrderByDescending(x => x.Value).First().Value);

        }
    }
}