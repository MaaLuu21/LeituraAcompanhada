
using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.Services;
using LeituraAcompanhada.View.Utils;
using System.Security.Cryptography;

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
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine("|Qual filtro de busca deseja utilizar?|");
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine("|Titulo           -      [0]          |");
            Console.WriteLine("|Autor            -      [1]          |");
            Console.WriteLine("|Gênero           -      [2]          |");
            Console.WriteLine(" -------------------------------------");
            Console.Write(": ");
            string? entrada = Console.ReadLine()?.Trim();

            parseOk = Enum.TryParse(entrada, out opcoes) && Enum.IsDefined(typeof(OpcoesFiltro), opcoes);

            if (string.IsNullOrEmpty(entrada) || !parseOk)
            {
                ConsoleUtils.MostrarErro("Opção inválida");

            }

            //instanciando as variaveis
            LivroFiltro livroFiltro = new LivroFiltro();
            FiltroService filtroService = new FiltroService();
            List<Livro> livrosFiltrados = new List<Livro>();

            switch (opcoes)
            {
                case OpcoesFiltro.Titulo:
                    //le o titulo do usuario
                    string titulo = EntradaUtils.LerString("Insira o titulo: ");
                    //livroFiltro recebe o titulo que o usuario inseriu
                    livroFiltro.Titulo = titulo;
                    //livrosFiltrados recebe metodo de filtragem passando como argumento o livro que o usuario digitou
                    livrosFiltrados = filtroService.Filtrar(livroFiltro);

                    break;

                case OpcoesFiltro.Autor:
                    //le o titulo do usuario
                    string autor = EntradaUtils.LerString("Insira o autor: ");
                    //livroFiltro recebe o titulo que o usuario inseriu
                    livroFiltro.Autor = autor;
                    //livrosFiltrados recebe metodo de filtragem passando como argumento o livro que o usuario digitou
                    livrosFiltrados = filtroService.Filtrar(livroFiltro);

                    break;

                case OpcoesFiltro.Genero:
                    //le o titulo do usuario
                    string genero = EntradaUtils.LerString("Insira o gênero: ");
                    //livroFiltro recebe o titulo que o usuario inseriu
                    livroFiltro.Genero = genero;
                    //livrosFiltrados recebe metodo de filtragem passando como argumento o livro que o usuario digitou
                    livrosFiltrados = filtroService.Filtrar(livroFiltro);

                    break;

                default:
                    break;
            }

            if (livrosFiltrados.Count == 0)
            {
                ConsoleUtils.MostrarErro("Nenhum livro foi encontrado com os critérios!!");
                return new List<Livro>();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("           LIVROS ENCONTRADOS      ");
                Console.WriteLine();
                foreach (var livro in livrosFiltrados)
                {
                    Console.WriteLine(livro);
                }
            }

            Console.WriteLine("Aperte qualquer tecla para voltar...");
            Console.ReadKey();

            return new List<Livro>();
        }
    }
}
