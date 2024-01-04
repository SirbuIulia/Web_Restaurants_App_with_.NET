using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_Programare.Data;
using Proiect_Medii_Programare.Models;

namespace Proiect_Medii_Programare.Pages.Rezervari
{
    [Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly Proiect_Medii_Programare.Data.Proiect_Medii_ProgramareContext _context;
       
        public IndexModel(Proiect_Medii_Programare.Data.Proiect_Medii_ProgramareContext context)
        {
            _context = context;
            
        }

        public IList<Rezervare> Rezervare { get;set; } = default!;

        public async Task OnGetAsync(int? clientId)
        {
            IQueryable<Rezervare> rezervariQuery = _context.Rezervare;

            if (clientId.HasValue)
            {
                rezervariQuery = rezervariQuery.Where(r => r.ClientID == clientId.Value);
            }

            
            Rezervare = await rezervariQuery.ToListAsync();

            if (_context.Rezervare != null)
            {
                Rezervare = await _context.Rezervare
                    .Include(b => b.Restaurant)
                    .Include(b => b.Client)
                    .ToListAsync();
            }
        }
    }
}
