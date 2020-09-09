using Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CarRentals.UI.Extensions
{
    public class CarConvertManager : ICarConvertSertvice
    {
        private string url = "https://localhost:44315/api/cars/getall";

        public List<CarInformation> GetList()
        {
            using (var w = new WebClient())
            {
                var json = w.DownloadString(url);
                var carInfo = JsonConvert.DeserializeObject<List<CarInformation>>(json);

                return carInfo;
            }
        }
        public CarInformation GetById(int carId)
        {
            throw new NotImplementedException();
        }

    }
}
