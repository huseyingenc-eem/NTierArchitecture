using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(c => c.CustomerName)
                .NotNull()
                .WithMessage("Müşteri adı boş geçilemez.");

            RuleFor(c => c.Phone)
               .NotNull()
               .WithMessage("Telefon numarası boş geçilemez.")
               .Matches("^[0-9]{11}$")
               .WithMessage("Telefon numarasına 10 haneden fazla girilemez ve sadece rakam girilebilir.");

            RuleFor(c => c.Country)
                .NotEmpty()
                .WithMessage("Şehir alanı boş geçilemez.");

            RuleFor(c => c.City)
               .NotNull()
               .WithMessage("Şehir alanı boş geçilemez.");
        }

    }
}
