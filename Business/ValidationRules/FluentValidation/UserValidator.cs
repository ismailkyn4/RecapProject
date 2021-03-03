using Business.Constants;
using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).MinimumLength(3).WithMessage(Messages.FirstNameInvalid);
            RuleFor(p => p.LastName).MinimumLength(3).WithMessage(Messages.LastNameInvalid);
            RuleFor(p => p.Email).Must(ContainsAt).WithMessage(Messages.EmailInvalid);
            // RuleFor(p => p.PasswordHash.ToString()).MinimumLength(6).WithMessage(Messages.PasswordInvalid);
        }

        private bool ContainsAt(string arg)
        {
            return arg.Contains("@");
        }
    }
}
