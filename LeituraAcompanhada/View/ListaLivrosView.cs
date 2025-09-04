using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View
{
    class ListaLivrosView
    {
        public static void ListaLivros()
        {
            ExibirLivrosView.ExibirLivros();

            Console.WriteLine("Deseja acessar a lista de leitura de algum livro?");
            Console.WriteLine("[S] para sim  -  [N] para não e voltar ao menu anterior");
            string resp = EntradaUtils.LerString(": ").ToLower();
            
            if (resp == "s")
            {
                int livroId = EntradaUtils.LerInteiro("Insira o ID do livro:");

                var livros = LivroRepository.Carregar();
                var livro = livros.Find(l => l.Id == livroId);

                var leituras = livro.Leituras.ToList();

                //arrumar com isso funciona só pode adiconar leitura se o status for concluido

                foreach(var leitura in leituras)
                {
                    Console.WriteLine(leitura);
                }
                Console.ReadKey();
            }
            else
            {
                return;
            }

        }
    }
}
