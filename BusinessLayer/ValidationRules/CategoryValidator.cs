using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Açıklama satırı boş bırakılamaz");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Lütfen az 3 karakter girişi yapın");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage("20 karakterden fazla girdiniz");
        }
    }
}
