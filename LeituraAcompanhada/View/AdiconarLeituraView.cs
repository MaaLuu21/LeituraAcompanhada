using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using LeituraAcompanhada.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraAcompanhada.View
{
    class AdiconarLeituraView
    {
        public static Leitura AdicionarLeitura()
        {

            DateTime dataInicio = EntradaUtils.LerData("Data de início: ");
            DateTime dataTermino = EntradaUtils.LerData("Data de termino: ");
            
            Console.WriteLine("Status");
            Console.WriteLine("Lendo - [0] | Quero ler [1] | Concluído [2]");
            Status status = EntradaUtils.LerEnum<Status>(": ");

            Random randNum = new Random();
            int id = randNum.Next(111111, 1000000);


            return new Leitura(dataInicio, dataTermino, status, id);
        }
    }
}
