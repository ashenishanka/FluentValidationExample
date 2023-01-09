using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationExample
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() {
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name cannot be empty");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name cannot be empty");
            RuleFor(x => x.address).NotEmpty().Length(20,255).WithMessage("Please check the address");
            RuleFor(x => x.Email).EmailAddress();

        }
    }
}
