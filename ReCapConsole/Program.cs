// See https://aka.ms/new-console-template for more information

using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

 CarManager carManager = new CarManager(new InMemory());

 foreach (var car in carManager.GetAll())
 {
    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.Description);
}

