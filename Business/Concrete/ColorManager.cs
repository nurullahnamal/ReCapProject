﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _icolorDal;

        public ColorManager(IColorDal colorDal)
        {
            _icolorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _icolorDal.GetAll();
        }
    }
}
