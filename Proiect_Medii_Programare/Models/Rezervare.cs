using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Proiect_Medii_Programare.Models
{
    public class Rezervare
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Data rezervării este obligatorie.")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Ora rezervării este obligatorie.")]
        [DataType(DataType.Time)]
        public TimeSpan Ora { get; set; }

        [Required(ErrorMessage = "Numărul de persoane este obligatoriu.")]
        [Range(1, int.MaxValue, ErrorMessage = "Numărul de persoane trebuie să fie cel puțin 1.")]
        public int NumarPersoane { get; set; }

       public int? ClientID { get; set; }
       public Client? Client { get; set; }

        public int? RestaurantID { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
