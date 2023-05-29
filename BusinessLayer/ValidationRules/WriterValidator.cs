using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer name and surname should not be blank.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter at least 2 characters.");
            RuleFor(x => x.WriterName).MinimumLength(50).WithMessage("Please enter a maximum of 50 characters");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adres should not be blank.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password should not be blank.");
        }
    }
}
