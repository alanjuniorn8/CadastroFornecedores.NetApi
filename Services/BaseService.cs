using CadastroFornecedores.Models;
using CadastroFornecedores.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace CadastroFornecedores.Services
{
    public abstract class BaseService
    {

        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string errorMessage)
        {
            _notificador.Handle(new Notificacao(errorMessage));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validator, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validationResult = validator.Validate(entidade);

            if (validationResult.IsValid) return true;
            
            Notificar(validationResult);

            return false;
        }
    }
}
