using LeituraAcompanhada.Entities.Enums;

namespace LeituraAcompanhada.Entities
{
    class Leitura
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public Status Status { get; set; }
        public int Id { get; set; }
        public int LivroId { get; set; }

        public Leitura() { }


        public Leitura(DateTime dataInicio, DateTime dataTermino, Status status, int id, int livroId)
        {
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Status = status;
            Id = id;
            LivroId = livroId;
        }



    }
}
