using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(p=>p.ColorId==1).WithMessage("A ile Başlamalı");

            RuleFor(c => c.Description).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
