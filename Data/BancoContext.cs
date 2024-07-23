using crud_login_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_login_mvc.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
      
    }
}
