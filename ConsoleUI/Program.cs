using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.InMemort;
using Entities.Abstract;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("Id:"+car.Id+" "+"BrandId: "+car.BrandId + " " +"ColorId: "+car.ColorId + "Price:"+" " +car.DailyPrice + " "+"Description:" +car.Description+"  "+"ModelYear: "+car.ModelYear);
            }




        }
    }
}
