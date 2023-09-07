// See https://aka.ms/new-console-template for more information

using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFremwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new InMemory());

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.Description);
//}
//InMemory inMemory = new InMemory();

//Car car1 = new Car();

//car1.CarName = "U";
//car1.DailyPrice = 10;



//inMemory.Add(car1);


EfBrandDal efBrandDal = new EfBrandDal();



Car newCar = new Car { CarId = 6, BrandId = 6, ColorId = 7, DailyPrice = 600, Description = "6.araba GÜNCELLENDİ", ModelYear = 2026 };
Brand newBrand = new Brand { BrandId = 5, BrandName = "Masserati" };
Brand newBrand2 = new Brand { BrandId = 6, BrandName = "Ford" };
Color newColor = new Color { ColorId = 5, ColorName = "Füme" };

BrandManager brandManager = new BrandManager(efBrandDal);

brandManager.Add(newBrand);
brandManager.Add(newBrand2);