using CleanBackend.Application.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanBackend.Application.Validators
{
    public class CreateItemCommandValidator : AbstractValidator<CreateItemCommand>
    {
        public CreateItemCommandValidator()
        {
            RuleFor(i => i.Id).NotEmpty().MinimumLength(2);
            RuleFor(i => i.Name).NotEmpty().MinimumLength(2);
        }
    }
}
