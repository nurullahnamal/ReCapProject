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
using Business.CSS;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using System.Runtime.ConstrainedExecution;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        IBrandService _brandService;

        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _CarDal = carDal;
            _brandService = brandService;
            
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {  
           IResult result= BusinessRules.Run(CheckIfBrandCountofBrandCorrect(car.BrandId),
                CheckIfBrandDescriptionExists(car.Description), CheckIfBrandLimitExceded());

            if (result!=null)
            {
                return result;
            }
            _CarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
           
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_CarDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_CarDal.GetCarDetails());
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            var result = _CarDal.GetAll(c => c.BrandId == car.BrandId).Count;
            if (result > 15)
            {
                return new ErrorResult(Messages.CarNameInValid);
            }

            throw new NotImplementedException();
        }


        private IResult CheckIfBrandCountofBrandCorrect(int BrandId)
        {
            var result = _CarDal.GetAll(c => c.BrandId == BrandId).Count;
            if (result > 15)
            {
                return new ErrorResult(Messages.CarCountOfBrandError);
            }

            return new SuccessResult();
        }

        private IResult CheckIfBrandDescriptionExists(string description)
        {
            var result = _CarDal.GetAll(c => c.Description == description).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarDescriptionAlReadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfBrandLimitExceded()
        {
            var result = _brandService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.BrandLimitExceded);
            }

            return new SuccessResult();
        }
    }
}
