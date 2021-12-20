using Microsoft.EntityFrameworkCore;

namespace dotnetsln2.Models.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<User> users { get; set; }
    }
}
