using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GameDashboard.Models
{
    public partial class GameDBContext : DbContext
    {
        public GameDBContext()
        {
        }

        public GameDBContext(DbContextOptions<GameDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Spil> Spil { get; set; }
              

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spil>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filnavn)
                    .IsRequired()
                    .HasColumnName("Filnavn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Score).HasColumnName("Score");

                entity.Property(e => e.Spil1)
                    .IsRequired()
                    .HasColumnName("Spil")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
