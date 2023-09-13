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
        //Car car2 = new Car();
        //Car car3 = new Car();

        car1.BrandId = 2;
        car1.ColorId = 3;
        car1.CarName = "Ford";
        car1.ModelYear = 2000;
        car1.DailyPrice = 35000;
        car1.Description = "Ford Focus";

        CarManager carManager = new CarManager(new EfCarDal());

        //carManager.Add(car1);


        List<Car> cars = new();
        cars = carManager.GetAll();

        foreach (var item in cars)
        {
            Console.WriteLine(item.CarName);
        }

        Console.ReadLine();



        //foreach (var item in carManager.GetAll(x => x.CarId == 4))
        //{
        //    Console.WriteLine(item.CarName);

        //}

        //carManager.Delete(car1);

        //carManager.GetCarsByBrandId(5);

    }
}