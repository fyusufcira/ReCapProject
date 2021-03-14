using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             //join b in context.Brands
                             //on c.BrandId equals b.BrandId
                             //join clr in context.Colors
                             //on c.ColorId equals clr.ColorId
                             //bunları join edince niyeyse ekrana boş geliyor. çözemedim.
                             select new CarDetailDTO
                             {
                                 BrandId=c.BrandId,
                                 ColorId = c.ColorId,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 Id = c.Id,
                                 ModelYear = c.ModelYear
                             };
                //from cr in context.Cars
                //join b in context.Brands on cr.BrandId equals b.Id
                //join cl in context.Colors on cr.ColorId equals cl.Id
                //select new CarDetailDto
                //{
                //    CarId = cr.Id,
                //    CarName = cr.Description,
                //    BrandName = b.BrandName,
                //    ColorName = cl.ColorName,
                //    DailyPrice = cr.DailyPrice
                //};
                return result.ToList();
            }
        }
    }
        
       
    
}

