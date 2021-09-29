using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Devmonk.API.Models
{
    public partial class mysql_17753_devmonkContext : DbContext
    {
        public mysql_17753_devmonkContext()
        {
        }

        public mysql_17753_devmonkContext(DbContextOptions<mysql_17753_devmonkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCliente> TbClientes { get; set; }
        public virtual DbSet<TbProduto> TbProdutos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=my01.winhost.com;user id=devmonk;password=devmonk;database=mysql_17753_devmonk", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PRIMARY");

                entity.Property(e => e.VlAvaliacao).HasPrecision(10, 2);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
