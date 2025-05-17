namespace APITaller.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }

    }
}
