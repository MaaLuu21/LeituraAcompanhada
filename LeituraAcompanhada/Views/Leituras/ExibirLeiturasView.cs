using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Livros;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Leituras
{
    class ExibirLeiturasView
    {
        public static bool ExibirLeituras()
        {
            var livros = LivroRepository.Carregar();

            ExibirLivrosView.ExibirLivros();

            Console.Write("\n\nInsira o ID do livro que deseja acessar as leituras: ");
            //checa se é um inteiro
            if (!int.TryParse(Console.ReadLine(), out int livroId))
            {
                ConsoleUtils.MostrarErro("Entrada inválida");
                return false;
            }

            //encontra o id
            var livro = livros.Find(l => l.Id == livroId);

            //se o id não for encontrado ele retorna mensasgem de erro e retorna
            if (livro == null)
            {
                ConsoleUtils.MostrarErro("O ID não foi encontrado!");
                return false;
            }

            var leituras = livro.Leituras.ToList();

            if (leituras == null || leituras.Count == 0)
            {
                ConsoleUtils.MostrarErro("Livro não possuí nenhuma leitura ainda");
                return false;
            }

            Console.Clear();
            foreach (var leitura in leituras)
            {
                Console.WriteLine(leitura);
            }
            Console.WriteLine("\nAperte qualquer tecla para voltar...");
            Console.ReadKey();

            return true;
        }
    }
}
