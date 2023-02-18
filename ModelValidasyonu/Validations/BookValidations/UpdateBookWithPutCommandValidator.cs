using FluentValidation;
using ModelValidasyonu.BookOperations.UpdateBook.UpdateWithPut;

namespace ModelValidasyonu.Validations.BookValidations
{
    public class UpdateBookWithPutCommandValidator : AbstractValidator<UpdateBookWithPutCommand>
    {
        public UpdateBookWithPutCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(1);
        }
    }
}
