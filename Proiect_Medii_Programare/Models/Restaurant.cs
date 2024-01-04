using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace Proiect_Medii_Programare.Models
{
    public class Restaurant
    {
        public int ID { get; set; }

        [Display(Name = "Denumire Restaurant")]
        public string Nume { get; set; }

        public string Adresa { get; set; }

        [RegularExpression(@"^0\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123' si sa inceapa cu 0")]
        public string NrTelefon { get; set; }

        [RegularExpression(@"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$", ErrorMessage = "URL-ul nu este valid.")]
        public string Website { get; set; }


        [Range(0, 5, ErrorMessage = "Ratingul trebuie să fie între 0 și 5")]
        public double RatingTotal { get; set; }
        

        public ICollection<Rezervare>? Rezervari { get; set; }
      
        public ICollection<Recenzie>? Recenzii { get; set; }

    }
}
