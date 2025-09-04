using LeituraAcompanhada.Entities.Enums;

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
            return "Data de início: "
                + DataInicio
                + "\nData de término: "
                + DataTermino
                + "\nStatus: "
                + Status;
        }
    }
}
