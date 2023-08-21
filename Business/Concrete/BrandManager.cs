using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 1)
            {
                return new ErrorResult(Messages.BrandAdd);
            }
            _brandDal.Add(brand);

            return new SuccessResult(Messages.BrandAdd);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            //iş kodları
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Brand>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<Brand> GetById(int carId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == carId));
        }

     
    }
}
