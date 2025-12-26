using FluentValidation;
using WebApi.Entities;

namespace WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş olmaz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ən az 2 simvol olamlıdır");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Ən çox 50 simvol olamlıdır");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Boş olmaz").GreaterThan(0).WithMessage("0 olmaz").LessThan(1000).WithMessage("1000-dən yuxarı olmaz");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş olmaz");
        }
    }
}
