using LeituraAcompanhada.Entities;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Livros
{
    class AdiconarLivroView
    {
        public static Livro AdicionarLivro()
        {
            //metodo para adionar o livro na classe livro
            string titulo = EntradaUtils.LerString("Título: ");
            string autor = EntradaUtils.LerString("Autor: ");
            string genero = EntradaUtils.LerString("Genero: ");

            Random randNum = new Random();
            int id = randNum.Next(111111, 1000000);

            return new Livro(titulo, autor, genero, id);
        }
    }
}
