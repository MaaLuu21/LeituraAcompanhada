using LeituraAcompanhada.Entities;

namespace LeituraAcompanhada.Services
{
    interface ILivroService
    {
        public List<Livro> Filtrar(LivroFiltro filtro);
    }
}
