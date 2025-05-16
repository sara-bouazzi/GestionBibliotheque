using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T.Core.Domaine;

namespace T.Data.Configurations
{
    public class PretLivreConfig : IEntityTypeConfiguration<PretLivre>
    {
        public void Configure(EntityTypeBuilder<PretLivre> builder)
        {
            builder.HasKey(e => new
            {
                e.AbonneFk,
                e.DateDebut,
                e.LivreFk
            });

            builder.HasOne(e => e.MyLivre)
                .WithMany(e => e.PretLivres)
                .HasForeignKey(e => e.LivreFk);

            builder.HasOne(e => e.MyAbonne)
                .WithMany(e => e.PretLivres)
                .HasForeignKey(e => e.AbonneFk);
        }
    }
}
