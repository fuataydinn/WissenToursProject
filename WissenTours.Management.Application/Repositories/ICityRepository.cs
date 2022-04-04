using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenTours.Domain;

namespace WissenTours.Management.Application.Repositories
{
    public interface ICityRepository
    {
        //Application katmanında oldugumuz icin, domain katmanından o sınıf gelmesi gerekiyor.
        IEnumerable<City> GetAll();
        City GetById(int id);
        void Update(City city);
        void Create(City city);
        void Delete(City city);


    }
}
