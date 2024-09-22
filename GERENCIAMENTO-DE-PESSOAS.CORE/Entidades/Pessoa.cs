using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GERENCIAMENTO_DE_PESSOAS.CORE.Entidades
{
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Formacao { get; set; }
    }
}