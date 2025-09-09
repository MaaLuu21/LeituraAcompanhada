using LeituraAcompanhada.Entities.Enums;

namespace LeituraAcompanhada.Entities
{
    class LivroFiltro
    {
        public string? Autor { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }

    
        public LivroFiltro() { }

        public LivroFiltro(string? autor, string? titulo, string? genero)
        {
            Autor = autor;
            Titulo = titulo;
            Genero = genero;

        }
    }

}
