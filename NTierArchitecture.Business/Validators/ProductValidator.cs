using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Category)
                .NotNull()
                .WithMessage("Ürün kategorisi boş geçilemez.");

            RuleFor(p => p.Supplier)
               .NotNull()
               .WithMessage("Ürün tedarikçisi boş geçilemez.");

            RuleFor(p => p.ProductName)
                .NotEmpty()
                .WithMessage("Ürün adı alanı boş geçilemez.")
                .Length(3, 100)
                .WithMessage("Ürün adı en az 3, en fazla 100 karakter olmalıdır.");

            RuleFor(p => p.UnitsInStock)
               .NotNull()
               .WithMessage("Ürün adedi boş geçilemez.")
               .GreaterThanOrEqualTo(0)
               .WithMessage("Ürün adedi negatif olamaz.")
               .LessThanOrEqualTo(10000)
               .WithMessage("Ürün adedi 10.000'den fazla olamaz.");

        }
    }
}
