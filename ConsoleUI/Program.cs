using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemort;
using Entities.Abstract;
using Entities.Concrete;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car6 = new Car() { Description = "opel castra temiz", ModelYear = "2008", DailyPrice = 100, BrandId = 3, ColorId = 1, Id = 6 };
            carManager.Add(car6);
            Car car5=  new Car() { BrandId = 8, ColorId = 3, DailyPrice = 90, Description = "merhabalar", Id = 5, ModelYear = "2015" };
            carManager.Add(car5);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("Id:"+car.Id+" "+"BrandId: "+car.BrandId + " " +"ColorId: "+car.ColorId + "Price:"+" " +car.DailyPrice + " "+"Description:" +car.Description+"  "+"ModelYear: "+car.ModelYear);
            }




        }
    }
}
