namespace LeituraAcompanhada.Entities
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Id { get; set; }
        public List<Leitura> Leituras { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, int id)
        {
            Titulo = titulo;
            Autor = autor;
            Id = id;
            Leituras = new List<Leitura>();
        }

        public Livro(string titulo, string autor, int id, List<Leitura> leituras)
        {
            Titulo = titulo;
            Autor = autor;
            Id = id;
            Leituras = leituras;
        }
    }
}
