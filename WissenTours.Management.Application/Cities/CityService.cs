using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenTours.Management.Application.Repositories;

namespace WissenTours.Management.Application.Cities
{
    public class CityService : ICityService
    {
        //Domaindeki City Class'ını buraya tasıdık constructor ile 
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public void Create(CityDTO city)
        {
            throw new NotImplementedException();
        }

        public void Delete(CityDTO city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CityDTO> GetAll()
        {
            var cityEntities = _cityRepository.GetAll(); //Domaindeki City nesnesini list olarak aldık.
            var cityDTOs = new List<CityDTO>();

            foreach (var entity in cityEntities) 
            {
                //City nesnesini CityDTO nesnesine Mapping yapıyorum --- Bu DTO presentation katmanına yollıyıcaz
                cityDTOs.Add(new CityDTO()
                {
                    Id = entity.Id,
                    Name=entity.Name
                });
            }
            return cityDTOs;
        }

        public CityDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CityDTO city)
        {
            throw new NotImplementedException();
        }
    }
}
