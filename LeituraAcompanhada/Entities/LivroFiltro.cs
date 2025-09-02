using LeituraAcompanhada.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.Entities
{
    class LivroFiltro
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public Status? Status { get; set; }//checa nulo
    }
}
