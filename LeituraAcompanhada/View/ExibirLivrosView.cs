using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.View
{
    class ExibirLivrosView
    {
        public static bool ExibirLivros()
        {
            var livros = LivroRepository.Carregar();
            if (livros == null || livros.Count == 0)
            {
                ConsoleUtils.MostrarErro("Nenhum livro cadastrado ainda");
                return false;
            }

            foreach (var livro in livros)
            {
                Console.WriteLine($"ID: {livro.Id} - Título: {livro.Titulo}");
            }
            return true;
        }
    }
}
