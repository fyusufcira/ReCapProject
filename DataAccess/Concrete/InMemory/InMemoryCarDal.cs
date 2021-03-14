using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //_cars = new List<Car>
            //{
            //    new Car{ BrandId=1, ColorId=5, DailyPrice=40, Description="Civic", Id=1, ModelYear="1998"},
            //    new Car{ BrandId=2, ColorId=1, DailyPrice=60, Description="Siyah Pasat", Id=2, ModelYear="1998"},
            //    new Car{ BrandId=1, ColorId=3, DailyPrice=80, Description="Golf", Id=3, ModelYear="1998"},
            //    new Car{ BrandId=3, ColorId=2, DailyPrice=20, Description="Polo", Id=4, ModelYear="1998"},
            //    new Car{ BrandId=4, ColorId=4, DailyPrice=100, Description="Bmw", Id=5, ModelYear="1998"}
            //};
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
        }
        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(cd => cd.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
