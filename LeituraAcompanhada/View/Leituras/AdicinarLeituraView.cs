using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View.Leituras
{
    class AdicinarLeituraView
    {
        public static Leitura AdicionarLeitura()
        {
            //metodo para adionar a leitura
            Status status;
            status = Status.Lendo;

            Random randNum = new Random();
            int id = randNum.Next(111111, 1000000);

            //usar o atualizarleitura

            if ( status == Status.Lendo)
            {
                DateTime dataInicio = EntradaUtils.LerData("Data de início: ");
                return new Leitura(status, id, dataInicio: dataInicio);
            }

            return new Leitura();
        }
    }
}
