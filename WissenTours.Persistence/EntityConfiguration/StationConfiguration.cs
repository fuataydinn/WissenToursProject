using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenTours.Domain;

namespace WissenTours.Persistence.EntityConfiguration
{
    class StationConfiguration : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired().HasColumnType("nvarchar(100)");

            builder.HasData(
                new Station() { Id = 1, CityId = 1, Name = "Esenler Otogarı" },
                new Station() { Id = 2, CityId = 1, Name = "Harem Otogarı" },
                new Station() { Id = 3, CityId = 2, Name = "Sakarya Büyükşehir Terminali" },
                new Station() { Id = 4, CityId = 3, Name = "Antalya Otogarı" },
                new Station() { Id = 5, CityId = 4, Name = "Ankara Otogarı" },
                new Station() { Id = 6, CityId = 5, Name = "Elazığ Otogarı" },
                new Station() { Id = 7, CityId = 3, Name = "Kaş Otogarı" }

                    );
        }
    }
}
