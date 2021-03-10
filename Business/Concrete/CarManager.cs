using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 1)
            {
                _carDal.Add(car);
                Console.WriteLine("New car added.");
            }
            else Console.WriteLine("Error. You can't add."); return;
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car deleted.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public Car GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(p => p.BrandId == BrandId);
        }

        public List<Car> GetCarsByColordId(int ColorId)
        {
            return _carDal.GetAll(p => p.ColorId == ColorId);

        }

        public List<CarDetailDTO> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("car updated.");
        }
    }
}
