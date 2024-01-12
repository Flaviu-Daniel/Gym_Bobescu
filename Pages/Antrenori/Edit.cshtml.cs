using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym_Bobescu.Data;
using Gym_Bobescu.Models;
using System.Security.Policy;

namespace Gym_Bobescu.Pages.Antrenori
{
    public class EditModel : PageModel
    {
        private readonly Gym_Bobescu.Data.Gym_BobescuContext _context;

        public EditModel(Gym_Bobescu.Data.Gym_BobescuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Antrenor Antrenor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var antrenor =  await _context.Antrenor.FirstOrDefaultAsync(m => m.ID == id);
            if (antrenor == null)
            {
                return NotFound();
            }
            Antrenor = antrenor;
            ViewData["SalaID"] = new SelectList(_context.Set<Sala>(), "ID",
"NumeSala");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Antrenor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AntrenorExists(Antrenor.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AntrenorExists(int id)
        {
            return _context.Antrenor.Any(e => e.ID == id);
        }
    }
}
