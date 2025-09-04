using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.Services;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View
{
    class InserirLeituraView
    {
        public static void InserirLeitura()
        {

            if (!ExibirLivrosView.ExibirLivros())
            {
                return; // sai do método se não houver livros
            }

            int id = EntradaUtils.LerInteiro("Insira o ID do livro que deseja inserir leitura: ");

            //chama o metodo que adicona a leitura
            string mensagem = LeituraService.AdicionarLeitura(id);

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
