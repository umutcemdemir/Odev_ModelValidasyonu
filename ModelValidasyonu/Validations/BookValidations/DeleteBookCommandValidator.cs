using FluentValidation;
using ModelValidasyonu.BookOperations.DeleteBook;

namespace ModelValidasyonu.Validations.BookValidations
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
        }
    }
}
