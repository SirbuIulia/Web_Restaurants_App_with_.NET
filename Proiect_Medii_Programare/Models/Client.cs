using System.ComponentModel.DataAnnotations;

namespace Proiect_Medii_Programare.Models
{
    public class Client
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")]
        [StringLength(30, MinimumLength = 3)]
        public string? Prenume { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        public string? NumeFamilie { get; set; }

        [StringLength(70)]
        public string Email { get; set; }

        [RegularExpression(@"^0\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123' si sa inceapa cu 0")]

        public string? NrTelefon { get; set; }


        [Display(Name = "Nume")]
        public string? Nume
        {
            get
            {
                return Prenume + " " + NumeFamilie;
            }
        }
        public ICollection<Rezervare>? Rezervari { get; set; }

        public ICollection<Recenzie>? Recenzii { get; set; }
        
    }
}
