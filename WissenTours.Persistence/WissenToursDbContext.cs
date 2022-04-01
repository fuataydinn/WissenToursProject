using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenTours.Domain;
using WissenTours.Persistence.EntityConfiguration;

namespace WissenTours.Persistence
{
    public class WissenToursDbContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=WissenToursDb;Integrated Security=true;";

        public DbSet<City> Cities { get; set; }
        public DbSet<Station> Stations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StationConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
