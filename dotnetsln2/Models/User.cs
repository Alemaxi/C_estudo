using dotnetsln2.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetsln2.Models
{
    public class User : BaseEntity
    {
        [Key]
        [Column("userId")]
        public override long? Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExipiryTime { get; set; }
    }
}
