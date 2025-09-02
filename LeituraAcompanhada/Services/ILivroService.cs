using LeituraAcompanhada.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.Services
{
    interface ILivroService
    {
        public List<Livro> Filtrar(LivroFiltro filtro);
    }
}
