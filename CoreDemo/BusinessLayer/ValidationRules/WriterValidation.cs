using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidation:AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Can't be empty");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Can't be empty");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Can't be empty");
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Must be a minimum of 8 characters");
        }

    }
}
