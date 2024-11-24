using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class SupplierValidator:AbstractValidator<Supplier>
    {
        public SupplierValidator() 
        {
            RuleFor(s => s.CompanyName)
                .NotNull()
                .WithMessage("Tedarikçi adı boş olamaz.");

            RuleFor(s => s.ContactTitle)
                .NotNull()
                .WithMessage("Ünvan alanı boş olamaz.");

            RuleFor(s => s.Country)
                .NotNull()
                .WithMessage("Şehir alanı boş olamaz.");

            RuleFor(s => s.City)
                .NotNull()
                .WithMessage("Şehir alanı boş olamaz.");

            RuleFor(s => s.Phone)
                .NotNull()
                .WithMessage("Telefon numarası boş geçilemez.")
                .Matches("^[0-9]{11}$")
                .WithMessage("Telefon numarasına 11 hane ve sadece rakam olmadıdır.");


        }
    }
}
