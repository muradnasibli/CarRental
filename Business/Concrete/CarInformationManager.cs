using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarInformationManager : ICarInformationService
    {
        private ICarInformationDal _carInfoDal;
        public CarInformationManager(ICarInformationDal carInfoDal)
        {
            _carInfoDal = carInfoDal;
        }
        public void Add(CarInformation carInformation)
        {
            _carInfoDal.Add(carInformation);
        }

        public void Delete(CarInformation carInformation)
        {
            _carInfoDal.Delete(carInformation);
        }

        public List<CarInformation> GetAll()
        {
            return _carInfoDal.GetList();
        }

        public CarInformation GetById(int carId)
        {
            return _carInfoDal.Get(x => x.Id == carId);
        }

        public List<CarInformation> GetByMake(int makeId)
        {
            return _carInfoDal.GetList(x => x.MakeId == makeId);
        }

        public void Update(CarInformation carInformation)
        {
            _carInfoDal.Update(carInformation);
        }
    }
}
