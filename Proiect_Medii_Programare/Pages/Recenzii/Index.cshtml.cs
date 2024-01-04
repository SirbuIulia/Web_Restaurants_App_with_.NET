using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_Programare.Data;
using Proiect_Medii_Programare.Models;
using Proiect_Medii_Programare.Models.ViewModels;

namespace Proiect_Medii_Programare.Pages.Recenzii
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Medii_Programare.Data.Proiect_Medii_ProgramareContext _context;

        public IndexModel(Proiect_Medii_Programare.Data.Proiect_Medii_ProgramareContext context)
        {
            _context = context;
        }

        public IList<Recenzie> Recenzie { get; set; } = default!;
        public RecenzieIndexData RecenzieData { get; set; }
        public int RecenzieID
        {
            get; set;
        }
        public int RestaurantID { get; set; }


        public async Task OnGetAsync(int? id)
        {
            RecenzieData = new RecenzieIndexData();
            RecenzieData.Recenzii = await _context.Recenzie
              .Include(i => i.Restaurant)
            //.ThenInclude(c => c.Recenzie)
             .OrderBy(i => i.Rating)
             .Include(b => b.Client).ToListAsync();

            if (id != null)
            {
                RecenzieID = id.Value;
                Recenzie recenzie = RecenzieData.Recenzii
                   .Where(i => i.ID == id.Value)
                   .Single();




            }
        }
    }
}

