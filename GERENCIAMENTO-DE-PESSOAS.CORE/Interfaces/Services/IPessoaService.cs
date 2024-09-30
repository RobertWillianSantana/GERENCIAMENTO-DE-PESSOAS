using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GERENCIAMENTO_DE_PESSOAS.CORE.DTO;
using GERENCIAMENTO_DE_PESSOAS.CORE.Entidades;

namespace GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Services
{
    public interface IPessoaService
    {
        Task AddPessoasAsync(PessoaDTO pessoaDTO);
        Task <List<PessoaDTO>> ObterTodasAsPessoasAsync();
        Task<PessoaDTO> ObterPessoaPorIdAsync(int id);
        Task RemovePessoaAsync(int id);
    }
}