using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator() 
        {
            //RuleFor(o => o.Employee)
            //    .NotNull()
            //    .WithMessage("Siparişin Çalışan bilgisi boş olamaz.");

            //RuleFor(o => o.Customer)
            //    .NotNull()
            //    .WithMessage("Siparişin Müşteri bilgisi boş olamaz.");

            RuleFor(o => o.OrderDate)
              .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
              .WithMessage("Sipariş tarihi bugünün tarihinden önceki bir tarih olamaz.");


        }
    }
}
