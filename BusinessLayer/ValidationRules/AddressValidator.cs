using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 Boş geçemezsiniz");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 Boş geçemezsiniz");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 Boş geçemezsiniz");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 Boş geçemezsiniz");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita Boş geçemezsiniz");

        }
    }
}
