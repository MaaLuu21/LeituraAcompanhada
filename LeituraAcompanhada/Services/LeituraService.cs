using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.Services
{
    class LeituraService
    {
        public static string AdicionarLeitura(int livroId)
        {
            bool result = LeituraRepository.AdicinarLeitura(livroId);



            if (result)
            {
                return "Leitura adicionada com sucesso";
            }
            else
            {
                return "Livro não encontrado";
            }
        }
        public static string AtualizarStatus(int livroId, int leituraId, Status novoStatus)
        {
            bool result = LeituraRepository.AtualizarStatus(livroId, leituraId, novoStatus);

            if (result)
            {
                return "Status atualizado com sucesso";
            }
            else
            {
                return "Livro ou leitura não encontrados";
            }

        }
    }
}
