using Business.Abstract;
using CarRentals.UI.Models;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;

namespace CarRentals.UI.Extensions
{
    public class CarConvertManager : ICarConvertSertvice
    {
        private readonly ICarInformationService _carInfoService;
        public CarConvertManager(ICarInformationService carInfoService)
        {
            _carInfoService = carInfoService;
        }
        
        private string url = "https://localhost:44315/api/cars/";

        public List<CarInformation> GetList()
        {
            using (var w = new WebClient())
            {
                var json = w.DownloadString(url + "/getall");
                var carInfo = JsonConvert.DeserializeObject<List<CarInformation>>(json);
                return carInfo;
            }
        }
        public CarInformation GetById(int carId)
        {
            using (var w = new WebClient())
            {
                var carsInfo = GetList();
                var carData = carsInfo.Where(x => x.ModelId == x.ModelId).Single();
                return carData;
            }
        }

        //public IQueryable<CarInformation> Include(params Expression<Func<CarInformation, object>>[] expressions)
        //{
        //    IQueryable<CarInformation> set = _dbContext.CarInformations;
        //    foreach(var includeExpressions in expressions)
        //    {
        //        set = set.Include(includeExpressions);
        //    }
        //    return set;
        //}
    }
}
