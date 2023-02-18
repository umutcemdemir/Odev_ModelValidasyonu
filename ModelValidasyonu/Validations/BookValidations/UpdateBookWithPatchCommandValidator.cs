﻿using FluentValidation;
using ModelValidasyonu.BookOperations.UpdateBook.UpdateBookWithPatch;

namespace ModelValidasyonu.Validations.BookValidations
{
    public class UpdateBookWithPatchCommandValidator : AbstractValidator<UpdateBookWithPatchCommand>
    {
        public UpdateBookWithPatchCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(1);
        }
    }
}
