using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Exceptions;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Filtros;
using LeituraAcompanhada.View.Leituras;
using LeituraAcompanhada.View.Livros;
using LeituraAcompanhada.View.Utils;


namespace LeituraAcompanhada.View
{
    class MenuView
    {
        public static void Menu()
        {
            bool parseOk = false;
            OpcoesMenu opcoes;
            List<Livro> livros = LivroRepository.Carregar();

            try
            {

                while (true)
                {
                    Console.Clear();
                    //menu simples de console
                    Console.WriteLine(" -------------------------------------------");
                    Console.WriteLine("|            LEITURA ACOMPANHADA            |");
                    Console.WriteLine(" -------------------------------------------");
                    Console.WriteLine("|Inserir livro           -     [0]          |");
                    Console.WriteLine("|Inserir leitura         -     [1]          |");
                    Console.WriteLine("|Lista de livros         -     [2]          |");
                    Console.WriteLine("|Historico de leituras   -     [3]          |");
                    Console.WriteLine("|Atualizar Leitura       -     [4]          |");
                    Console.WriteLine("|Filtro de busca         -     [5]          |");
                    Console.WriteLine("|Sair                    -     [6]          |");
                    Console.WriteLine(" -------------------------------------------");
                    string entrada = Console.ReadLine()?.Trim();//checa se a entrada não for nula e tira espaço em branco se tiver no final

                    //checa se a entrada condiz com as opcoes do enum
                    parseOk = Enum.TryParse(entrada, out opcoes) && Enum.IsDefined(typeof(OpcoesMenu), opcoes);

                    if (string.IsNullOrEmpty(entrada) || !parseOk)
                    {
                        ConsoleUtils.MostrarErro("Opção inválida");
                        continue;
                    }

                    switch (opcoes)
                    {
                        case OpcoesMenu.InserirLivro:
                            Console.Clear();

                            //Recebe os dados do usuario
                            Livro livro = AdiconarLivroView.AdicionarLivro();

                            //adiona na lista de livros os dados
                            livros.Add(livro);
                            //atualiza a lista
                            LivroRepository.Salvar(livros);

                            break;

                        case OpcoesMenu.InserirLeitura:
                            Console.Clear();
                            InserirLeituraView.InserirLeitura();

                            break;

                        case OpcoesMenu.ListaLivros:
                            Console.Clear();
                            ExibirLivrosView.ExibirLivros();
                            Console.WriteLine("\nAperte qualquer tecla para voltar...");
                            Console.ReadKey();

                            break;

                        case OpcoesMenu.HistoricoLeituras:
                            Console.Clear();
                            ExibirLeiturasView.ExibirLeituras();

                            break;

                        case OpcoesMenu.AtualizarStatus:
                            Console.Clear();
                            AtualizarStatusView.AtualizarStatus();

                            break;

                        case OpcoesMenu.FiltroDeBusca:
                            Console.Clear();

                            FiltroView.Filtro();

                            break;

                        case OpcoesMenu.Sair:
                            Console.Clear();

                            return;

                        default:
                            break;
                    }
                }
            }
            catch (DomainException e)
            {
                ConsoleUtils.MostrarErro(e.Message);
            }
            catch (Exception e)
            {
                ConsoleUtils.MostrarErro("Erro inesperado" + e.Message);
            }
        }
    }
}
