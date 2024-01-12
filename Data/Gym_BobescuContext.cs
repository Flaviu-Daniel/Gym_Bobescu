using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gym_Bobescu.Models;

namespace Gym_Bobescu.Data
{
    public class Gym_BobescuContext : DbContext
    {
        public Gym_BobescuContext (DbContextOptions<Gym_BobescuContext> options)
            : base(options)
        {
        }

        public DbSet<Gym_Bobescu.Models.Client> Client { get; set; } = default!;
        public DbSet<Gym_Bobescu.Models.Antrenor> Antrenor { get; set; } = default!;
        public DbSet<Gym_Bobescu.Models.Sala> Sala { get; set; } = default!;
    }
}
