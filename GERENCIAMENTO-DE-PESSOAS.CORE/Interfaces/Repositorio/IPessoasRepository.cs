using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GERENCIAMENTO_DE_PESSOAS.CORE.DTO;
using GERENCIAMENTO_DE_PESSOAS.CORE.Entidades;

namespace GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Repositorio
{
    public interface IPessoasRepository
    {
        Task AddPessoasAsync(string Nome, string CPF, string Cidade, string Estado, string Formacao);
        Task <List<PessoaDTO>> ObterTodasAsPessoasAsync();
        Task<Pessoa?> ObterPessoaPorIdAsync(int id);
        Task<bool> EditarUmaPessoaAsync(int id, Pessoa pessoa);
        Task RemoverPessoaAsync(int id);
    }
}