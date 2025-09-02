namespace LeituraAcompanhada.Entities
{
    class Livro
    {
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public int Id { get; set; }
        public List<Leitura> Leituras { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, int id, List<Leitura> leituras)
        {
            Titulo = titulo;
            Autor = autor;
            Id = id;
            Leituras = leituras;
        }
    }
}
