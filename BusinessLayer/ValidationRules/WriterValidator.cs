using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz");
            RuleFor(w => w.WriterSurname).NotEmpty().WithMessage("Yazar soy adı satırı boş bırakılamaz");
            RuleFor(w => w.WriterAbout).NotEmpty().WithMessage("Hakkımda satırı boş bırakılamaz");
            RuleFor(w => w.WriterTitle).NotEmpty().WithMessage("Ünvan satırı boş bırakılamaz");
            RuleFor(w => w.WriterName).MinimumLength(2).WithMessage("Lütfen az 2 karakter girişi yapın");
            RuleFor(w => w.WriterSurname).MaximumLength(20).WithMessage("20 karakterden fazla girdiniz");

            //RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
        }
    }
}
