using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Exceptions;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.View
{
    class MenuView
    {
        public static void Menu()
        {
            bool parseOk = false;
            Opcoes opcoes;
            List<Livro> livros = LivroRepository.Carregar();

            try
            {

                while (true)
                {
                    //menu simples de console
                    Console.WriteLine(" -------------------------------------------");
                    Console.WriteLine("|            LEITURA ACOMPANHADA            |");
                    Console.WriteLine(" -------------------------------------------");
                    Console.WriteLine("|Inserir livro      -     [0]               |");
                    Console.WriteLine("|Inserir leitura    -     [1]               |");
                    Console.WriteLine("|Atualizar Status   -     [2]               |");
                    Console.WriteLine(" -------------------------------------------");
                    string entrada = Console.ReadLine()?.Trim();//checa se a entrada não for nula e tira espaço em branco se tiver no final
                    
                    //checa se a entrada condiz com as opcoes do enum
                    parseOk = Enum.TryParse(entrada, out opcoes) && Enum.IsDefined(typeof(Opcoes), opcoes);

                    if (string.IsNullOrEmpty(entrada) || !parseOk)
                    {
                        ConsoleUtils.MostrarErro("Opção inválida");
                        continue;
                    }

                    switch (opcoes)
                    {
                        case Opcoes.InserirLivro:
                            Console.Clear();

                            //Recebe os dados do usuario
                            Livro livro = AdiconarLivroView.AdicionarLivro();

                            //adiona na lista de livros os dados
                            livros.Add(livro);
                            //atualiza a lista
                            LivroRepository.Salvar(livros);

                            break;

                        case Opcoes.InserirLeitura:
                            Console.Clear();
                            InserirLeituraView.InserirLeitura();

                            break;
                        case Opcoes.AtualizarStatus:
                            
                            break;
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
                ConsoleUtils.MostrarErro("Erro inesperado");
            }
        }
    }
}
