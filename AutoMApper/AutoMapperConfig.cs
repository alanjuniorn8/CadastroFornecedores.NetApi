using AutoMapper;
using CadastroDeFornecedoresApi.Models;
using CadastroDeFornecedoresApi.ViewModels;

namespace CadastroDeFornecedoresApi.AutoMApper
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