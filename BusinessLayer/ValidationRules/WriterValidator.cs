using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator: AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Adı soyadı kısmı boş geçilemez!");   
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!");   
            RuleFor(x => x.WriterPAssword).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girşi yapınız!");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girşi yapınız!");
        }
    }
}
