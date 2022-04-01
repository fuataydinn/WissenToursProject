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
        public IEnumerable<City> GetAll()
        {
            //veri tabanına en son repositoryler erisir
            //Wissen Persistence katmanından cagırdık bunu 

            //sonra Startup sınıfına git ...

            var context = new WissenToursDbContext();

            return context.Cities.ToList();
        }
    }
}
