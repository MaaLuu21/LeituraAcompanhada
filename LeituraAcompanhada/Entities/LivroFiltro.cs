using LeituraAcompanhada.Entities.Enums;

namespace LeituraAcompanhada.Entities
{
    class LivroFiltro
    {
        public string? Autor { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public Status? Status { get; set; }//checa nulo
    
        public LivroFiltro() { }

        public LivroFiltro(string? autor, string? titulo, string? genero, Status? status)
        {
            Autor = autor;
            Titulo = titulo;
            Genero = genero;
            Status = status;
        }
    }

}
