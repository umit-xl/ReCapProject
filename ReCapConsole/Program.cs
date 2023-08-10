// See https://aka.ms/new-console-template for more information

using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new InMemory());

// foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.Description);
//}

InMemory inMemory = new InMemory();

Car car1 = new Car();

car1.CarName = "Umit";
car1.DailyPrice = 10;


inMemory.Add(car1);

