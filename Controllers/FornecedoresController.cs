using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CadastroFornecedores.Repositories.Interfaces;
using CadastroFornecedores.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeFornecedoresApi.Controllers
{
    [Route("api/fornecedores")]
    public class FornecedoresController : MainController
    {
        private readonly IMapper _mapper;
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedoresController(IMapper mapper, IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return Ok(fornecedores);
        }
        
    }
}