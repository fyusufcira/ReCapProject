using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //CRUD 
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("CARS||| car ıd: "+car.Id+" car description: "+car.Description+" car color Id: "+car.ColorId
                    +" car brand ıd: "+car.BrandId+" car model year: "+car.ModelYear);
            }
            foreach (var car in carManager.GetByUnitPrice(0,80))
            {
                System.Console.WriteLine(car.Id);
            }
            carManager.Add(new Car { Id = 7, BrandId = 4, ColorId = 5, DailyPrice = 130, Description = "PASSAT QASQHAI", ModelYear = "2019" }) ;
        
        }
    }
}