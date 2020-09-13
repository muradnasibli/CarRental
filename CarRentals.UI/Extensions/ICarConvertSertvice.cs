using CarRentals.UI.Models;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentals.UI.Extensions
{
    public interface ICarConvertSertvice
    {
        CarInformation GetById(int carId);
        List<CarInformation> GetList();
        //IQueryable<CarInformation> Include(params Expression<Func<CarInformation, object>>[] expressions);

    }
}
