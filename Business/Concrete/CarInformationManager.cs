using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //return _carInfoDal.Include(x => x.Ban, x => x.City, x => x.Color,
            //                                x => x.Condition, x => x.Description, x => x.Image,
            //                                        x => x.Make, x => x.Model, x => x.Transmission).ToList();
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
