﻿using Businnes.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal) 
        {
            _carDal = carDal;
        }
        

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
