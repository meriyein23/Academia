using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    
    {
        public int ID { get; set; }
        public string Clase { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime Horario { get; set; }
        public int Aula { get; set; }
        public string Profesor { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}