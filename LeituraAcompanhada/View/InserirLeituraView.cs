using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.Services;
using LeituraAcompanhada.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.View
{
    class InserirLeituraView
    {
        public static void InserirLeitura()
        {
            ExibirLivrosView.ExibirLivros();

            if (!ExibirLivrosView.ExibirLivros())
            {
                return; // sai do método se não houver livros
            }

            int id = EntradaUtils.LerInteiro("Insira o ID do livro que deseja inserir leitura: ");

            
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
