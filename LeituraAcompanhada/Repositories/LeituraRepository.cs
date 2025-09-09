using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.View.Leituras;
using LeituraAcompanhada.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.Repositories
{
    class LeituraRepository
    {
        public static bool AdicinarLeitura(int livroId)
        {
            //Carrega a lista de livros
            var livros = LivroRepository.Carregar();
            if (livros == null || livros.Count == 0)
            {
                return false;
            }

            // encontra o livro pelo ID
            var livroParaAtualizar = livros.FirstOrDefault(l => l.Id == livroId && l.Leituras.All(leitura => leitura.Status != Status.Lendo));

            if (livroParaAtualizar == null)
            {
                return false;
            }

            //Coleta os dados da leitura
            Leitura novaLeitura = AdicinarLeituraView.AdicionarLeitura();

            //Define o livroID na nova leitura
            novaLeitura.LivroId = livroId;

            livroParaAtualizar.Leituras.Add(novaLeitura);

            LivroRepository.Salvar(livros);

            return true;
        }

        public static bool AtualizarStatus(int livroId, int leituraId, Status novoStatus, DateTime dataTermino)
        {
            //carrega todos os livros
            var livros = LivroRepository.Carregar();

            //encontra o livro certo pelo ID
            var livro = livros.Find(l => l.Id == livroId);

            //Verifica se o livro foi encontrado
            if (livro != null)
            {
                //encontra a leitura certa do livro 
                var leituraExistente = livro.Leituras.Find(l => l.Id == leituraId);

                if (leituraExistente != null)
                {
                    leituraExistente.Status = novoStatus;//Atualiza
                    leituraExistente.DataTermino = dataTermino;
                    LivroRepository.Salvar(livros);//Salva
                    return true;
                }
            }
            //Se não encontrar retorna false
            return false;
        }
    }
}
