using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Repositories;

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
                return "Livro não encontrado ou está sendo lido no momento";
            }
        }
        public static string AtualizarStatus(int livroId, int leituraId, Status novoStatus, DateTime dataTermino)
        {
            bool result = LeituraRepository.AtualizarStatus(livroId, leituraId, novoStatus, dataTermino);

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
