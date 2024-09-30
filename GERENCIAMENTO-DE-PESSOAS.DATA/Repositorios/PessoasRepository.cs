using System.Security.Cryptography;
using Dapper;
using GERENCIAMENTO_DE_PESSOAS.CORE.DTO;
using GERENCIAMENTO_DE_PESSOAS.CORE.Entidades;
using GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace GERENCIAMENTO_DE_PESSOAS.DATA.Repositorios
{
    public class PessoasRepository : IPessoasRepository
    {
        private readonly GerenciamentoDbContext _dbcontext;

        public PessoasRepository(GerenciamentoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // Metodo que faz a insersão no banco de dados
        public async Task AddPessoasAsync(string Nome, string CPF, string Cidade, string Estado, string Formacao)
        {

            var pessoa = new Pessoa
            {
                Nome = Nome,
                CPF = CPF,
                Cidade = Cidade,
                Estado = Estado,
                Formacao = Formacao

            };

            await _dbcontext.AddAsync(pessoa);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<PessoaDTO> ObterPessoaPorIdAsync(int id)
        {
            var pessoa = await _dbcontext.Pessoas.FindAsync(id);

            var pessoaDTO = new PessoaDTO()
            {
                Nome = pessoa.Nome,
                CPF = pessoa.CPF,
                Cidade = pessoa.Cidade,
                Estado = pessoa.Estado,
                Formacao = pessoa.Formacao
            };

            return pessoaDTO;

        }

        public async Task<List<PessoaDTO>> ObterTodasAsPessoasAsync()
        {
            return await _dbcontext.Pessoas.Select(p => new PessoaDTO
            {
                Nome = p.Nome ?? "N/A",
                CPF = p.CPF ?? "N/A",
                Cidade = p.Cidade ?? "Unknown",
                Estado = p.Estado ?? "Unknown",
                Formacao = p.Formacao ?? "Unknown"
            }).ToListAsync();
        }

        public async Task RemoverPessoaAsync(int id)
        {
            var pessoa = await _dbcontext.Pessoas.FindAsync(id);

            _dbcontext.Pessoas.Remove(pessoa);

            await _dbcontext.SaveChangesAsync();
        }
    }
}
