using dotnetsln2.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetsln2.Models
{
    public class Pessoa : BaseEntity
    {
        [Key]
        [Column("pessoaId")]
        public override long? Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
