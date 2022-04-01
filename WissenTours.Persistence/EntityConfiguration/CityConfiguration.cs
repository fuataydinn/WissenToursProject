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
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(100)");

            builder.HasData(new City() {Id=1,Name="İstanbul" });
            builder.HasData(new City() {Id=2,Name="Sakarya" });
            builder.HasData(new City() {Id=3,Name="Antalya" });
            builder.HasData(new City() {Id=4,Name="Ankara" });
            builder.HasData(new City() {Id=5,Name="Elazığ" });

        }
    }
}
