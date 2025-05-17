namespace APITaller.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<string> Detalles { get; set; }
        public decimal Total { get; set; }

    }
}
