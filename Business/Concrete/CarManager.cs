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
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),true,"Araçlar Listelendi");
        }

        public List<Car> GetAllById(int id)
        {
            return _CarDal.GetAll(c => c.CarId == id);
        }

        public Car GetById(int carId)
        {
            return _CarDal.Get(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }
    }
}
