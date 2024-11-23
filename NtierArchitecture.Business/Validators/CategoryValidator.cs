using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Business.Validators
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Kategori alani boş geçilemez.")
                .MinimumLength(5).WithMessage("Kategori adı minumum 5 karekter olmalıdır.")
                .MaximumLength(25).WithMessage("Kategori adı maximum 25 karekter olmalıdır.")
                .Matches("^[a-zA-ZğüşıöçĞÜŞİÖÇ\\s]+$").WithMessage("Lütfen sadece harf girişi yapınız.");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
        }
    }
}
