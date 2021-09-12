using System;
using System.Linq;
using System.Threading.Tasks;
using CadastroDeFornecedoresApi.Models;
using CadastroDeFornecedoresApi.Notificacoes.Interfaces;
using CadastroDeFornecedoresApi.Repositories.Interfaces;
using CadastroDeFornecedoresApi.Services.Interfaces;
using CadastroDeFornecedoresApi.Validators;

namespace CadastroDeFornecedoresApi.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {

        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, IEnderecoRepository enderecoRepository, INotificador notificador)
            : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
        }

        public async Task<bool> Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidator(), fornecedor)
                 || !ExecutarValidacao(new EnderecoValidator(), fornecedor.Endereco)) return false;

            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar("Já existe um fornecedor cadastrado com este documento.");
                return false;
            }

            await _fornecedorRepository.Adicionar(fornecedor);
            return true;
        }

        public async Task<bool> Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidator(), fornecedor)) return false;

            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id).Result.Any())
            {
                Notificar("Já existe um fornecedor cadastrado com este documento.");
                return false;
            }

            await _fornecedorRepository.Atualizar(fornecedor);
            return true;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidator(), endereco)) return;

            await _enderecoRepository.Atualizar(endereco);
        }

        public async Task<bool> Remover(Guid id)
        {
            if (_fornecedorRepository.ObterFornecedorProdutosEndereco(id).Result.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos cadastrados!");
                return false;
            }

            var enderecoFornecedor = await _enderecoRepository.ObterEnderecoPorFornecedor(id);
            
            await _enderecoRepository.Remover(enderecoFornecedor.Id);
            await _fornecedorRepository.Remover(id);
            return true;
        }

        public void Dispose()
        {
            _fornecedorRepository?.Dispose();
            _enderecoRepository?.Dispose();
        }

    }
}
