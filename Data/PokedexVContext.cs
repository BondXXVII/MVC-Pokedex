using Microsoft.EntityFrameworkCore;
using PokedexV.Models;

namespace PokedexV.Data
{
    public class PokedexVContext : DbContext
    {
        public PokedexVContext (DbContextOptions<PokedexVContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemon { get; set; }

        public DbSet<PokedexV.Models.TrainerStuff> TrainerStuff { get; set; }

        public DbSet<PokedexV.Models.CaughtPk> CaughtPk { get; set; }

        // public DbSet<TrainerStuff> Trainer { get; set; }

        
    }
}