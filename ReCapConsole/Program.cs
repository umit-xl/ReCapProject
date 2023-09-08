// See https://aka.ms/new-console-template for more information

using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFremwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new InMemory());

internal class Program
{
    private static void Main(string[] args)
    {
        //foreach (var car in carManager.GetAll())
        //{
        //    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.Description);
        //}
        //InMemory inMemory = new InMemory();

        Car car1 = new Car();

        car1.CarName = "Umit";
        car1.DailyPrice = 10;
        car1.CarId = 3;
        car1.BrandId = 5;



        //inMemory.Add(car1);

        CarManager carManager = new CarManager(new EfCarDal());

        //carManager.Add(car1);

        //carManager.Delete(car1);

        carManager.Add(car1);


    }
}