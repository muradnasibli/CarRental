using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarRentals.UI.Models;
using Business.Abstract;
using CarRentals.UI.Extensions;

namespace CarRentals.UI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ICarInformationService _carInfo;
        private readonly ICarConvertSertvice _carJson;

        public HomeController(/*ICarInformationService carInfo*/ ICarConvertSertvice carJson)
        {
            //_carInfo = carInfo;
            _carJson = carJson;
        }

        public IActionResult Index()
        {
            //TODO: List edilende city adi gorsensin. Include etmek lazimdir.
            var data = _carJson.GetList();     
            return View(data);
        }

        public IActionResult Listing()
        {
            var data = _carJson.GetList();
            return View(data);
        }

    }
}
