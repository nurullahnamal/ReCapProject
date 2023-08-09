using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands on car.BrandId equals b.BrandId
                             join co in context.Colors on car.ColorId equals co.ColorId
                             join o in context.Customers on car.UserId equals o.UserId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 ModelYear = car.ModelYear,
                                 BrandName = b.BrandName,
                                 Description = car.Description,
                                 DailyPrice = car.DailyPrice,
                                 ColorName=co.ColorName,
                                 CompanyName = o.CompanyName
                                 
                             };
                return result.ToList();

            }
        }
    }
}
