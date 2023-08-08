using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryStock.Models
{
    [Table("Tabelas")]
    public class Tabela
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo \" {0} \" é obrigatorio")]
        public string? Nome { get; set; }
    }
}
