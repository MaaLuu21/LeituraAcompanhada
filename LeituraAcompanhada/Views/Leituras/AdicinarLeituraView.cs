using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.Repositories;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Leituras
{
    class AdicinarLeituraView
    {
        public static Leitura AdicionarLeitura()
        {
            var livros = LivroRepository.Carregar();

            //metodo para adionar a leitura
            Status status;
            status = Status.Lendo;

            //id da leitura
            Random randNum = new Random();
            int id;
            //testar se o id é repetido
            do
            {

                id = randNum.Next(111111, 1000000);

            } while (livros.SelectMany(l => l.Leituras).Any(leitura => leitura.Id == id));

            DateTime dataInicio;
            do
            {
                dataInicio = EntradaUtils.LerData("Data de início: ");
                if (dataInicio > DateTime.Today)
                {
                    ConsoleUtils.MostrarErro("A data de início não pode ser maior que a de hoje");
                }
            } while (dataInicio > DateTime.Today);




            return new Leitura(status, id, dataInicio: dataInicio);
        }
    }
}
