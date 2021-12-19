using Microsoft.EntityFrameworkCore;

namespace dotnetsln2.Models.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
