using System.Collections.Generic;

namespace CadastroDeFornecedoresApi.Notificacoes.Interfaces
{
    public interface INotificador
    {
        void Handle(Notificacao notificacao);
        List<Notificacao> ObterNotificacoes();
        bool TemNotificacão();

    }
}
