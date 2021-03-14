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
            var resultOne = carManager.GetCarDetails();
            foreach (var car in resultOne.Data)
            {
                System.Console.WriteLine("Car Id:"+car.Id+" DAILYPRICE: "+car.DailyPrice+" DESCRIPTION:"+car.Description+" MODEL YEAR: "+car.ModelYear);
            }

            var resultTwo = carManager.GetByUnitPrice(0, 100);

            foreach (var car in resultTwo.Data)
            {
                System.Console.WriteLine("\n");
                System.Console.WriteLine("NAME: "+car.Description+" PRICE:"+car.DailyPrice);
            }
            
        
        }
    }
}