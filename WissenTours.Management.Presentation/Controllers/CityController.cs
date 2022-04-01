using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WissenTours.Management.Application.Cities;

namespace WissenTours.Management.Presentation.Controllers
{
    //Loosely Coupling VS Tightly Coupling
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        // Ben bu interface'ın concret'ini nereden alıcam diyor constructor
        //Startup dosyasındaki metot bu interface'in concrate sınıfını soyler ...!
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        //public IActionResult Index()
        //{
        //    var dbContext = new WissenToursDbContext();
        //    var cities = dbContext.Cities.ToList();
        //    return View(cities);
        //}

        public IActionResult Index()
        {
            //Service
            //Aslında çok genel bir ifade, ama yine de Business/Application katmanında islemlerin yapıldıgı nesnelere verilen isim 
            //CityService
            //StationService
            
            //Bu iş yapılsın kimin yaptıgı onemli degil
            var cities = _cityService.GetAll();
          
            
            return View(cities);
        }
    }
}
