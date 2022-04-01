using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenTours.Management.Application.Cities
{
    //Üzerinde davranıs (behavior) olmayan, sadece veri barındıran sınıflara POCO sınıfı

    //DTO (Data Transfer Object) 
    //Bir projede katmanlar arasında sadece veri tasımak icin kullanılan uzerinde 
    //davranıs olmayan (POCO cinsi) sınıflardır
     
    //Bu proje ozelinde; DTO sınıflarımız Presentation <-> Application katmanları arasında veri tasıyacak
    //DTO :  domain ve ve presantation arasında veri tasıyacak. Presentation direk DOMAİN e erismesin istedigimiz icin.
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}