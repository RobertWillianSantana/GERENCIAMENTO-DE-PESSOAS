using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GERENCIAMENTO_DE_PESSOAS.CORE.DTO
{
    public class PessoaDTO
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Formacao { get; set; }
    }
}