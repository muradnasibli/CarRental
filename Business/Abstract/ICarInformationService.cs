using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarInformationService 
    {
        List<CarInformation> GetAll();
        List<CarInformation> GetByMake(int makeId);
        CarInformation GetById(int carId);
        void Add(CarInformation carInformation);
        void Update(CarInformation carInformation);
        void Delete(CarInformation carInformation);
    }
}
