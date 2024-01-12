using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gym_Bobescu.Data;
using Gym_Bobescu.Models;

namespace Gym_Bobescu.Pages.Sali
{
    public class IndexModel : PageModel
    {
        private readonly Gym_Bobescu.Data.Gym_BobescuContext _context;

        public IndexModel(Gym_Bobescu.Data.Gym_BobescuContext context)
        {
            _context = context;
        }

        public IList<Sala> Sala { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Sala = await _context.Sala.ToListAsync();
        }
    }
}
