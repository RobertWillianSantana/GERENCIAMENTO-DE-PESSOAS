using GERENCIAMENTO_DE_PESSOAS.CORE.DTO;
using GERENCIAMENTO_DE_PESSOAS.CORE.Entidades;
using GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Repositorio;
using GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Services;

namespace GERENCIAMENTO_DE_PESSOAS.MANAGER.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoasRepository _repository;

        public PessoaService(IPessoasRepository repository)
        {
            _repository = repository;
        }

        public async Task AddPessoasAsync(PessoaDTO pessoaDTO)
        {
            await _repository.AddPessoasAsync(pessoaDTO.Nome, pessoaDTO.CPF, pessoaDTO.Cidade, pessoaDTO.Estado, pessoaDTO.Formacao);
        }

        public async Task<List<PessoaDTO>> ObterTodasAsPessoasAsync()
        {
            var pessoas = await _repository.ObterTodasAsPessoasAsync();
            
            return pessoas ?? new List<PessoaDTO>();
        }

        public async Task RemovePessoaAsync(int id)
        {
            await _repository.RemoverPessoaAsync(id);
        }
    }
}