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
    public class EfCarDal : EfEntityRepository<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             join o in context.Orders on c.OrderID equals o.OrderID
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName=co.ColorName,
                                 OrderDate=o.OrderDate
                                 
                             };
                return result.ToList();

            }
        }
    }
}
