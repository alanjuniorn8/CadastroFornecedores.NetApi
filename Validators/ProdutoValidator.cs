using CadastroFornecedores.Models;
using FluentValidation;

namespace CadastroFornecedores.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {

            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 50)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Descricao)
               .NotEmpty()
               .WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 200)
               .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            
            RuleFor(c => c.Valor)
              .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que 0");

        }
    }
}
