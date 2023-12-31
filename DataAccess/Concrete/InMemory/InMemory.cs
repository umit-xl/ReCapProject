﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemory : ICarDal
    {

        List<Car> _cars;

        public InMemory()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2018, Description = "Otomatik vites"},
                new Car {Id = 2, BrandId = 4, ColorId = 1, DailyPrice = 200000, ModelYear = 2003, Description = "Manuel vites"}
            };
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _cars.Add(car);

                foreach (var item in _cars)
                {
                    Console.WriteLine(item.Id);
                }
            }

            else
            {
                Console.WriteLine("Araba ismi 2 harften uzun ve Araba fiyatı 0 Tl'den yüksek olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carDelete);

            foreach (var item in _cars)
            {
                Console.WriteLine(item.Id);
            }

        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carUpdate.Id = car.Id;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;


        }

        public List<Car> GetByld(int CarId)
        {
            return _cars.Where(c => c.Id == CarId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars.ToList();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Func<Car, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Func<Car, bool> filter)
        {
            throw new NotImplementedException();
        }
    }
}
