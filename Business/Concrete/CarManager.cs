using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }
        public List<Car> GetAll()
        {
            return  _CarDal.GetAll();
        }

        public List<Car> GetAllById(int id)
        {
            return _CarDal.GetAll(c => c.ColorId == 1);
        }

       

        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }
    }
}
