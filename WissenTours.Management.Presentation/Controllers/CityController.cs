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

        public IActionResult GetById(int id)
        {
            var city = _cityService.GetById(id);
            if (city != null)
            {
                return View(city);
            }
            else
            {
                return Content("kayıt bulunamadı");
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CityDTO city)
        {
            _cityService.Create(city);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var city = _cityService.GetById(id);
            return View(city);
        }

        [HttpPost]
        public IActionResult Update(CityDTO city)
        {
            if (city != null)
            {
                _cityService.Update(city);

                return RedirectToAction("Index");
                //return View(city);
            }
            return Content("Hatalı işlem");
        }

        public IActionResult Delete(CityDTO cityDTO)
        {
            if (cityDTO != null)
            {
                var city = _cityService.GetById(cityDTO.Id);
                _cityService.Delete(city);
                return RedirectToAction("Index");
            }
            return Content("Silinecek kayıt bulunamadı");
        }




    }
}
