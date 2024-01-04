using Proiect_Medii_Programare.Models;
using System.Security.Policy;

namespace Proiect_Medii_Programare.Models.ViewModels
{
    public class RecenzieIndexData
    {
        public IEnumerable<Recenzie> Recenzii { get; set; }
        public IEnumerable<Restaurant> Restaurante { get; set; }
    }
}
