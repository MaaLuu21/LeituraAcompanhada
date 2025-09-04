using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.Services
{
    class FiltroService : ILivroService
    {
        public List<Livro> Filtrar(LivroFiltro filtro)
        {
            //Carrega os livros
            var livros = LivroRepository.Carregar();
            var query = livros.AsEnumerable();

            if (!string.IsNullOrEmpty(filtro.Titulo)) 
            {
                query = query.Where(l => l.Titulo.IndexOf(filtro.Titulo, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (!string.IsNullOrEmpty(filtro.Autor))
            {
                query = query.Where(l => l.Autor.IndexOf(filtro.Autor, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (!string.IsNullOrEmpty(filtro.Genero))
            {
                query = query.Where(l => l.Genero.IndexOf(filtro.Genero, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            if (filtro.Status.HasValue)
            {
                query = query.Where(l => l.Leituras.Any(le => le.Status == filtro.Status));
            }

            return query.ToList();
        }
    }
}
