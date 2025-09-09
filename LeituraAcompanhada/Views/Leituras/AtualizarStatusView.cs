using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.Services;
using LeituraAcompanhada.View.Livros;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Leituras
{
    class AtualizarStatusView
    {
        public static bool AtualizarStatus()
        {
            //Faz a leitura do id do livro
            Console.Write("Insira o ID do");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" livro ");
            Console.ResetColor();
            Console.Write("que deseja atualizar: ");
            if (!int.TryParse(Console.ReadLine(), out int livroId))
            {
                ConsoleUtils.MostrarErro("Entrada inválida");
                return false;
            }

            if (livroId == null)
            {
                ConsoleUtils.MostrarErro("Entrada Invalida");
                return false;
            }
            var livros = LivroRepository.Carregar();
            var livro = livros.FirstOrDefault(l => l.Id == livroId);
            if (livro == null)
            {
                ConsoleUtils.MostrarErro("Livro não encontrado");
                return false;
            }
            Console.Write("\nInsira o ID da ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" leitura ");
            Console.ResetColor();
            Console.Write("que deseja atualizar: ");
            if (!int.TryParse(Console.ReadLine(), out int leituraId))
            {
                ConsoleUtils.MostrarErro("Entrada inválida");
                return false;
            }

            if (leituraId == null)
            {
                ConsoleUtils.MostrarErro("Entrada inválida");
                return false;
            }

            var leitura = livro.Leituras.FirstOrDefault(le => le.Id == leituraId);
            if (leitura == null)
            {
                ConsoleUtils.MostrarErro("Leitura não encontrada.");
                return false;
            }

            if (leitura.Status == Status.Concluido)
            {
                ConsoleUtils.MostrarErro("Esta leitura já foi concluída!");
                return false;
            }

            Status novoStatus = Status.Concluido;

            DateTime dataTermino = DateTime.Now.Date;

            LeituraRepository.AtualizarStatus(livroId, leituraId, novoStatus, dataTermino);

            string mensagem = LeituraService.AtualizarStatus(livroId, leituraId, novoStatus, dataTermino);

            //Mostra se foi adicionado com sucesso ou não

            //dar uma melhorada aqui!!!!!!!!!!!!
            //!!!!!!!!
            if (mensagem.Contains("sucesso", StringComparison.OrdinalIgnoreCase))
            {
                ConsoleUtils.MostrarSucesso(mensagem);
            }
            else
            {
                ConsoleUtils.MostrarErro(mensagem);
            }

            return true;

        }
    }
}
