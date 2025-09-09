
using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.Services;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Filtros
{
    class FiltroView
    {
        public static List<Livro> Filtro()
        {
            var livros = LivroRepository.Carregar();
            bool parseOk = false;
            OpcoesFiltro opcoes;

            if (livros == null || livros.Count == 0)
            {
                ConsoleUtils.MostrarErro("Nenhum livro cadastrado ainda!");
                return new List<Livro>();
            }

            Console.WriteLine("Qual filtro de busca deseja utilizar?");
            Console.WriteLine("Titulo   -  [0]");
            Console.WriteLine("Autor    -  [1]");
            Console.WriteLine("Gênero   -  [2]");
            Console.WriteLine("Status   -  [3]");
            string? entrada = Console.ReadLine()?.Trim();

            parseOk = Enum.TryParse(entrada, out opcoes) && Enum.IsDefined(typeof(OpcoesFiltro), opcoes);

            if (string.IsNullOrEmpty(entrada) || !parseOk)
            {
                ConsoleUtils.MostrarErro("Opção inválida");
                return new List<Livro>();
            }

            switch (opcoes)
            {
                case OpcoesFiltro.Titulo: 
                    string titulo = EntradaUtils.LerString("Insira o titulo: ");

                    LivroFiltro livroFiltro = new LivroFiltro();
                    livroFiltro.Titulo = titulo;
                                            
                    FiltroService filtro = new FiltroService();
                    var filtrado = filtro.Filtrar(livroFiltro);

                    foreach(var livro in filtrado)
                    {
                        Console.WriteLine(livro);
                    }
                    Console.ReadKey();

                    break;

                default:
                    break;
            }


            return new List<Livro>();
        }
    }
}
