using FluentValidation;
using ModelValidasyonu.BookOperations.GetBookDetail.GetById;

namespace ModelValidasyonu.Validations.BookValidations
{
    public class GetBookByIdQueryValidator : AbstractValidator<GetBookByIdQuery>
    {
        public GetBookByIdQueryValidator()
        {
            RuleFor(query => query.BookId).GreaterThan(0);
        }
    }
}
