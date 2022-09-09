using DataAccess.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class JobsValidator : AbstractValidator<Job>
    {
        public JobsValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(x => x.Company).NotEmpty().WithMessage("Company name cannot be empty");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address cannot be empty");
            RuleFor(x => x.Responsibility).MinimumLength(151).WithMessage("Responsibility can be a minimum of 151 characters");
        }
    }
}
