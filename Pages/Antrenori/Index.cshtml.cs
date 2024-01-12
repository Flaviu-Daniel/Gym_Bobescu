using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Bobescu.Data;
using Gym_Bobescu.Models;

namespace Gym_Bobescu.Pages.Antrenori
{
    public class IndexModel : PageModel
    {
        private readonly Gym_Bobescu.Data.Gym_BobescuContext _context;

        public IndexModel(Gym_Bobescu.Data.Gym_BobescuContext context)
        {
            _context = context;
        }

        public IList<Antrenor> Antrenor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Antrenor = await _context.Antrenor
                .Include(b => b.Sala)
                .ToListAsync();
        }
    }
}
