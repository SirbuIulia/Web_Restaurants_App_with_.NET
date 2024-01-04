using System.ComponentModel.DataAnnotations;

namespace Proiect_Medii_Programare.Models
{
    public class Recenzie
    {
        public int ID { get; set; }

        [MaxLength(500, ErrorMessage = "Comentariul nu poate depăși 500 de caractere.")]
        public string Comentariu { get; set; }

        [Range(0, 5, ErrorMessage = "Ratingul trebuie să fie între 0 și 5")]
        public int Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public Recenzie()
        {
            Data = DateTime.Now;
        }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
        // public ICollection<Restaurant>? Restaurante { get; set; }
      
        public int? RestaurantID { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
