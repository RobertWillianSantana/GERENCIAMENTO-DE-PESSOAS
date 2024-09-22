using GERENCIAMENTO_DE_PESSOAS.CORE.DTO;
using GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace GERENCIAMENTO_DE_PESSOAS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewPessoa([FromBody]PessoaDTO pessoaDTO)
        {   
            await _service.AddPessoasAsync(pessoaDTO);

            return NoContent();
        }

        [HttpGet("obter-pessoas")]
        public async Task<IActionResult> GetAllPessoas()
        {
            var pessoas = await _service.ObterTodasAsPessoasAsync();

            return Ok(pessoas);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarPessoa([FromQuery] int id)
        {
            await _service.RemovePessoaAsync(id);

            return NoContent();
        }
    }
}