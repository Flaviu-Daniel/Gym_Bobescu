using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Bobescu.Data;
using Gym_Bobescu.Models;

namespace Gym_Bobescu.Pages.Clienti
{
    public class DetailsModel : PageModel
    {
        private readonly Gym_Bobescu.Data.Gym_BobescuContext _context;

        public DetailsModel(Gym_Bobescu.Data.Gym_BobescuContext context)
        {
            _context = context;
        }

        public Client Client { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }
            else
            {
                Client = client;
            }
            return Page();
        }
    }
}
