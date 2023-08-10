using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List <Car> GetAll();
        List <Car> GetAllById(int id);
        List<CarDetailDto> GetCarDetails();
        Car GetById(int carId);
        IResult Add(Car car);
    }
}
