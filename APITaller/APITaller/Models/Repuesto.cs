namespace APITaller.Models
{
    public class Repuesto
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Marca { get; set; }
        public int Stock { get; set; }
        public decimal PrecioUnitario
        {
            get;

        }
    }
}
