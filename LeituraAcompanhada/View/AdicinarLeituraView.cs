using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.View.Utils;

namespace LeituraAcompanhada.View
{
    class AdicinarLeituraView
    {
        public static Leitura AdicionarLeitura()
        {


            //metodo para adionar a leitura
            Console.WriteLine("Status");
            Console.WriteLine("Lendo - [0] | Quero ler [1] | Concluído [2]");
            Status status = EntradaUtils.LerEnum<Status>(": ");

            Random randNum = new Random();
            int id = randNum.Next(111111, 1000000);

            //usar o atualizarleitura

            switch (status)
            {
                case Status.Lendo:
                    DateTime dataInicio = EntradaUtils.LerData("Data de início: ");
                    return new Leitura(status, id, dataInicio: dataInicio);
                case Status.Concluido:
                    DateTime dataTermino = EntradaUtils.LerData("Data de término: ");
                    return new Leitura(status, id, dataTermino: dataTermino);

                default:
                    break;
            }

            return new Leitura();
        }
    }
}
