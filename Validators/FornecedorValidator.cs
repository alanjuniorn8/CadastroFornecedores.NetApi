using CadastroFornecedores.Models;
using CadastroFornecedores.Validators.Documentos;
using FluentValidation;

namespace CadastroFornecedores.Validators
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 50)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                
                RuleFor(f => f.Documento.Length).Equal(CpfValidator.TamanhoCpf)
                    .WithMessage("O campo Documento pecisa ter {ComparisonValue} caracters.");
                
                RuleFor(f => CpfValidator.Validar(f.Documento)).Equal(true)
                    .WithMessage("O Documento fornecido é inválido.");

            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {

                RuleFor(f => f.Documento.Length).Equal(CnpjValidator.TamanhoCnpj)
                    .WithMessage("O campo Documento pecisa ter {ComparisonValue} caracters.");

                RuleFor(f => CnpjValidator.Validar(f.Documento)).Equal(true)
                    .WithMessage("O Documento fornecido é inválido.");

            });


        }
    }
}
