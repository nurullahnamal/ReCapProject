﻿using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        //IDataResult<List<Car>> GetAll();
         //List<Brand>GetAll();
         //IResult Add(Brand brand);

         IDataResult<List<Brand>> GetAll();
         IDataResult<List<Brand>> GetAllById(int id);
         IDataResult<Brand> GetById(int brandId);
         IResult Add(Brand brand );

    }
}
