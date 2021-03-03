using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemort;
using Entities.Abstract;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { Description = "opel castra temiz", ModelYear = "2008", DailyPrice = 100, BrandId = 3, ColorId = 1, Id = 1 };
            carManager.Add(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    System.Console.WriteLine("Id:"+car.Id+" "+"BrandId: "+car.BrandId + " " +"ColorId: "+car.ColorId + "Price:"+" " +car.DailyPrice + " "+"Description:" +car.Description+"  "+"ModelYear: "+car.ModelYear);
            //}




        }
    }
}
