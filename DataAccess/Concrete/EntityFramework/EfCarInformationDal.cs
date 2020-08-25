﻿using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarInformationDal : EfEntityRepositoryBase<CarInformation, CarCreditAppDbContext>, ICarInformationDal 
    {
    }
}
