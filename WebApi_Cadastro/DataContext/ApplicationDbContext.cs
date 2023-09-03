using Microsoft.EntityFrameworkCore;
using WebApi_Cadastro.Models;

namespace WebApi_Cadastro.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
