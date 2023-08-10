﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInValid = "Araç ismi Geçersiz";
        internal static List<Car> MaintenanceTime;
        internal static string CarsListed;
    }
}