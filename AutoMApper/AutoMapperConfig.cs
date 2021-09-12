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
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();

            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<Produto, ProdutoViewModel>()
            .ForMember(dest => dest.NomeFornecedor, 
                        opt => opt.MapFrom(src => src.Fornecedor.Nome ));
        }
        
    }
}