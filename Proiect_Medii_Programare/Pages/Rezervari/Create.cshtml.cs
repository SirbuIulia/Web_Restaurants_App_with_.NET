using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Medii_Programare.Data;
using Proiect_Medii_Programare.Models;

namespace Proiect_Medii_Programare.Pages.Rezervari
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Medii_Programare.Data.Proiect_Medii_ProgramareContext _context;

        public CreateModel(Proiect_Medii_Programare.Data.Proiect_Medii_ProgramareContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["RestaurantID"] = new SelectList(_context.Set<Restaurant>(), "ID", "Nume");
            ViewData["ClientID"] = new SelectList(_context.Client, "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Rezervare Rezervare { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Rezervare == null || Rezervare == null)
            {
                return Page();
            }
            Rezervare.Client = await _context.Client.FindAsync(Rezervare.ClientID);
            _context.Rezervare.Add(Rezervare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
