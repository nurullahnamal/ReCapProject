using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length<5)
            {
                return new ErrorResult(Messages.CarNameInValid);
            }
           _CarDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodları
            if (DateTime.Now.Hour==17)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult <List<Car>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Car>>( _CarDal.GetAll(c => c.CarId == id));
        }

        public IDataResult< Car> GetById(int carId)
        {
            return new SuccessDataResult<Car> (_CarDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _CarDal.GetCarDetails());
        }
    }
}
