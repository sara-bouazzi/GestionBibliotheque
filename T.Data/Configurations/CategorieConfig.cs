using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T.Core.Domaine;

namespace T.Data.Configurations
{
    public class CategorieConfig : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.HasMany(e => e.Livres)
                .WithOne(e => e.MyCategorie)
                .HasForeignKey(e => e.CategorieId);
        }
    }
}
