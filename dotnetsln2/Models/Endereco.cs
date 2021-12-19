using dotnetsln2.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetsln2.Models
{
    public class Endereco : BaseEntity
    {
        [Key]
        [Column("enderecoId")]
        public override long? Id { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long? pessoaId { get; set; }
    }
}
