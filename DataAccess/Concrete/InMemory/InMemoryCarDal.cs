using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory;
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car { CarId = 1,BrandId=1,ColorId=4,DailyPrice=4400,ModelYear="2010-02-05",Description="Ford GT"},
//                new Car { CarId = 2,BrandId=2,ColorId=5,DailyPrice=144000,ModelYear="2006-02-05",Description="Porshe GT"},
//                new Car { CarId = 3,BrandId=3,ColorId=6,DailyPrice=37000,ModelYear="2005-02-05",Description="Renault GT"},
//                new Car { CarId = 4,BrandId=4,ColorId=6,DailyPrice=54000,ModelYear="2008-02-05",Description="WW GT"},
//                new Car { CarId = 5,BrandId=5,ColorId=0,DailyPrice=94000,ModelYear="2008-02-05",Description="MINI GT"},
//            };
//        }
//        public void Add(Car entity)
//        {
//            _cars.Add(entity);
//        }

//        public void Delete(Car entity)
//        {
//            Car CarDelete;
//            CarDelete = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
//        }


//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            return _cars;
//        }

//        public Car GetById(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car entity)
//        { 
//            Car CarUpdate;
//            CarUpdate = _cars.SingleOrDefault(p => p.CarId == entity.CarId);
//            CarUpdate.BrandId = entity.BrandId;
//            CarUpdate.ColorId = entity.ColorId;
//            CarUpdate.DailyPrice = entity.DailyPrice;
//            CarUpdate.ModelYear = entity.ModelYear;
//            CarUpdate.Description = entity.Description;
//        }
//    }
//}
