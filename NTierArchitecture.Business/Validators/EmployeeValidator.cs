using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.Name)
                .NotNull()
                .WithMessage("ad alanı boş geçilemez.")
                .Length(2, 50)
                .WithMessage(e => $"Ad '{e.Name}' geçersiz. En az 2, en fazla 50 karakter olmalıdır.");

            RuleFor(e => e.SurName)
                .NotNull()
                .WithMessage("Soyad alanı boş geçilemez.")
                .Length(2, 50)
                .WithMessage(e => $"Soyad '{e.SurName}' geçersiz. En az 2, en fazla 50 karakter olmalıdır.");

            RuleFor(e => e.Country)
                .NotNull()
                .WithMessage("ülke alanı boş geçilemez.");

            RuleFor(e => e.City)
                .NotNull()
                .WithMessage("Şehir alanı boş geçilemez.")
                .MinimumLength(3)
                .WithMessage("Şehir alanı minumum 3 harfli olmalıdır.");

            RuleFor(e => e.Phone)
               .NotNull()
               .WithMessage("Telefon numarası boş geçilemez.")
               .Matches("^[0-9]{11}$")
               .WithMessage("Telefon numarası 11 haneli ve sadece rakam olabilir.");

        }

    }
}
