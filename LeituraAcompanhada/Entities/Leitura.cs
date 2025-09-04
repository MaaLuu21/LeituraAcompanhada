using LeituraAcompanhada.Entities.Enums;
using System.Text;

namespace LeituraAcompanhada.Entities
{
    class Leitura
    {
        public DateTime? DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
        public Status Status { get; set; }
        public int Id { get; set; }
        public int? LivroId { get; set; }

        public Leitura() { }

        public Leitura(Status status, int id, int? livroId = null, DateTime? dataInicio = null, DateTime? dataTermino = null)
        {
            Status = status;
            Id = id;
            LivroId = livroId;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int tamanho = 35;

            sb.AppendLine(new String( '-', tamanho));

            if(DataInicio.HasValue)
            {
                sb.AppendLine("Data de início: " + DataInicio.Value.Date.ToShortDateString());
            }
            if (DataTermino.HasValue)
            {
                sb.AppendLine("Data de término: " + DataTermino.Value.Date.ToShortDateString());
            }

            sb.AppendLine("Status: " + Status);

            sb.AppendLine("ID: " + Id);

            sb.AppendLine(new String('-', tamanho));

            return sb.ToString();

        }
    }
}
