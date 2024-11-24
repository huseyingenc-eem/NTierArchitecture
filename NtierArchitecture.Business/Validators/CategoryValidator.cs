using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Kategori alanı boş geçilemez.")
                .MinimumLength(4).WithMessage("Kategori adı minimum 4 karakter olmadılıdır.")
                .MaximumLength(25).WithMessage("Kategori adı maximum 25 karakter olmadılıdır.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ\\s]+$").WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            
        }
    }
}
