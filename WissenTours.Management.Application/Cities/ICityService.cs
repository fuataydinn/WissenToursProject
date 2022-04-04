using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenTours.Domain;

namespace WissenTours.Management.Application.Cities
{
    //Interface 
    //Implementation (kodlama) yerine yalnızca yapılacak islerin adını
    //donus tıpını ve parametresini iceren soyutlama yapılarıdır.
    //Isın nasıl yapıldıgını degil hangi isin yapılacagını soylemektedir.

    //Peki işi (implementation) kim yapacak ?
    //yazdıgımız interface'i hangi sınıf implement ediyorsa isi/kodlamayı o yapacak

    //public class CityService : ICityService
    //yukarıda yazılan kodlamadaki sentaksa interface'ler ozelinde miras almak degil, interface'i IMPLEMENT ETMEK (uyarlamak/kodlamak) denir
     public interface ICityService
    {
        //Domain nesnesi yerine DTO (veri tasıma nesneleri) kullanıcaz ... Domain'e yalnızca Application mudahale etsin diye DTO olusturuyoruz. 
        //Aplication'da DTO olusturulacak

        CityDTO GetById(int id);
        IEnumerable<CityDTO> GetAll();
        //Concerete sınıfa bagımlı yapmamak ıcın List yerine IEnumerable atasını tanımladık, binevi bunu da soyutladık.

        void Create(CityDTO city);
        void Update(CityDTO city);
        void Delete(CityDTO city);
    }
}
