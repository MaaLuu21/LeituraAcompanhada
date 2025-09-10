using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Livros
{
    class AdiconarLivroView
    {
        public static Livro AdicionarLivro()
        {
            var livros = LivroRepository.Carregar();

            //metodo para adionar o livro na classe livro
            string titulo = EntradaUtils.LerString("Título: ");
            string autor = EntradaUtils.LerString("Autor: ");
            string genero = EntradaUtils.LerString("Genero: ");

            Random randNum = new Random();
            int id;
            //testar se o id é repetido
            do
            {
                
                id = randNum.Next(111111, 1000000);

            } while (livros.Any(l => l.Id == id));

            return new Livro(titulo, autor, genero, id);
        }
    }
}
