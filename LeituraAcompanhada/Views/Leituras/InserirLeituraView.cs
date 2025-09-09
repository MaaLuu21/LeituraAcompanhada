using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.Services;
using LeituraAcompanhada.View.Livros;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Leituras
{
    class InserirLeituraView
    {
        public static void InserirLeitura()
        {

            if (!ExibirLivrosView.ExibirLivros())
            {
                return; // sai do método se não houver livros
            }

            Console.Write("\n\nInsira o ID do livro que deseja inserir leitura: ");
            //checa se é inteiro
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                ConsoleUtils.MostrarErro("Entrada inválida");
                return;
            }

            //chama o metodo que adicona a leitura
            string mensagem = LeituraService.AdicionarLeitura(id);

            //Mostra se foi adicionado com sucesso ou não
            if (mensagem.Contains("sucesso", StringComparison.OrdinalIgnoreCase))
            {
                ConsoleUtils.MostrarSucesso(mensagem);
            }
            else
            {
                ConsoleUtils.MostrarErro(mensagem);
            }
        }
    }
}
