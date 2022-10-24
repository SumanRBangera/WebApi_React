using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi_React.Models
{
    public partial class reactContext : DbContext
    {
        public reactContext()
        {
        }

        public reactContext(DbContextOptions<reactContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> Cards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
   //             optionsBuilder.UseSqlServer("Server=ELW5127\\SQLEXPRESS01;Database=react;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("card");

              //  entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
