using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {

        List<Car> _cars;

        public InMemory() 
        {
            _cars = new List<Car> 
            { 
                new Car {CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 300000, ModelYear = 2018, Description = "Otomatik vites"}, 
                new Car {CarId = 2, BrandId = 4, ColorId = 1, DailyPrice = 200000, ModelYear = 2003, Description = "Manuel vites"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carDelete);

        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;


        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByld(int CarId)
        {
            return _cars.Where(c=> c.CarId==CarId).ToList();
        }

        
    }
}
