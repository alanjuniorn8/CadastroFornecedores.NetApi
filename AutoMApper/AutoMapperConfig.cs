using AutoMapper;
using CadastroFornecedores.Models;
using CadastroFornecedores.ViewModels;

namespace CadastroFornecedores.AutoMApper
{
    public class AutoMapperConfig : Profile
    {   

        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
        
    }
}