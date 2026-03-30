
using EleicaoBrasilApi.Moldes;
using Microsoft.EntityFrameworkCore;

namespace EleicaoBrasilApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        protected AppDbContext()
        {
        }

        public DbSet<Candidato>Candidatos{get;set;}
    }
}