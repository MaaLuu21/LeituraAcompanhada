using LeituraAcompanhada.Entities;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View
{
    class AdiconarLivroView
    {
        public static Livro AdicionarLivro()
        {
            string titulo = EntradaUtils.LerString("Título: ");
            string autor = EntradaUtils.LerString("Autor: ");

            Random randNum = new Random();
            int id = randNum.Next(111111, 1000000);

            return new Livro(titulo, autor, id);
        }
    }
}
