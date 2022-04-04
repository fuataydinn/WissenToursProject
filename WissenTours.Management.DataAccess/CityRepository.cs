using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenTours.Domain;
using WissenTours.Management.Application.Repositories;
using WissenTours.Persistence;

namespace WissenTours.Management.DataAccess
{
    public class CityRepository : ICityRepository
    {
        //veri tabanına en son repositoryler erisir
        //Wissen Persistence katmanından cagırdık bunu 

        //sonra Startup sınıfına git ..
        public IEnumerable<City> GetAll()
        {
            var context = new WissenToursDbContext();

            return context.Cities.ToList();
        }
        public void Create(City city)
        {
            var context = new WissenToursDbContext();
            context.Cities.Add(city);
            context.SaveChanges();
        }

        public void Delete(City cityDTO)
        {
            var context = new WissenToursDbContext();
            var city = context.Cities.Find(cityDTO.Id);
            context.Remove(city);
            context.SaveChanges();
        }

        public void Update(City city)
        {
            var context = new WissenToursDbContext();
            context.Cities.Update(city);
            context.SaveChanges();
        }

        public City GetById(int id)
        {
            var context = new WissenToursDbContext();
            var city = context.Cities.Find(id);
            return city;
        }

    }
}
