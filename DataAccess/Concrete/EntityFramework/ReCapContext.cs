﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-9JCHGP7\SQLEXPRESS;database=ReCapProject;integrated security=true;");
        }
        public DbSet<Car>Cars { get; set; }
        public DbSet<Brand>Brands{ get; set; }
        public DbSet<Color>Colors { get; set; }
        public DbSet<User>Users{ get; set; }
        public DbSet<Customer>Customers{ get; set; }


    }
}
