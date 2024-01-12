using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gym_Bobescu.Data;
using Gym_Bobescu.Models;
using System.Security.Policy;

namespace Gym_Bobescu.Pages.Antrenori
{
    public class CreateModel : PageModel
    {
        private readonly Gym_Bobescu.Data.Gym_BobescuContext _context;

        public CreateModel(Gym_Bobescu.Data.Gym_BobescuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SalaID"] = new SelectList(_context.Set<Sala>(), "ID",
"NumeSala");
            return Page();
        }

        [BindProperty]
        public Antrenor Antrenor { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Antrenor.Add(Antrenor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
