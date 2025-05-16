using Microsoft.EntityFrameworkCore;
using T.Core.Domaine;
using T.Data.Configurations;

namespace T.Data
{
    public class TContext : DbContext
    {
        public TContext(DbContextOptions<TContext> options) : base(options)
        {
        }

        public DbSet<Abonne> Abonnes { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<PretLivre> PretLivres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PretLivreConfig());
            modelBuilder.ApplyConfiguration(new CategorieConfig());
        }
    }
}
