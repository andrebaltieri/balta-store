using Balta.Store.Models;
using FluentValidation;

namespace Balta.Store.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).Length(3, 40).WithMessage("Nome inválido");
            RuleFor(x => x.LastName).Length(3, 40).WithMessage("Sobrenome inválido");
        }
    }
}