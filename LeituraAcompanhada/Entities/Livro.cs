using System.Text;

namespace LeituraAcompanhada.Entities
{
    class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Genero { get; set; }
        public int Id { get; set; }
        public List<Leitura> Leituras { get; set; }

        public Livro() { }

        public Livro(string? titulo, string? autor, string? genero, int id)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Id = id;
            Leituras = new List<Leitura>();
        }

        public Livro(string? titulo, string? autor, string? genero, int id, List<Leitura> leituras)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Id = id;
            Leituras = leituras ?? new List<Leitura>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int tamanho = 40;

            sb.AppendLine(new string('-', tamanho));
            sb.AppendLine("Titulo: " +  Titulo);
            sb.AppendLine("Autor: " + Autor);
            sb.AppendLine("Genero: " + Genero);
            sb.AppendLine("ID: " + Id );
            sb.AppendLine(new string('-', tamanho));


            return sb.ToString();

        }
    }
}
