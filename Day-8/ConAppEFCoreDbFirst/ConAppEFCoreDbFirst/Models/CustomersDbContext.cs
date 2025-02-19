using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConAppEFCoreDbFirst.Models;

public partial class CustomersDbContext : DbContext
{
    public CustomersDbContext()
    {
    }

    public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SALMANMCT\\SQLEXPRESS;Database=CustomersDb;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07382F5123");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fname).HasMaxLength(50);
            entity.Property(e => e.Lname).HasMaxLength(50);
            entity.Property(e => e.Medate).HasColumnName("MEDate");
            entity.Property(e => e.Mplan).HasColumnName("MPlan");
            entity.Property(e => e.Msdate).HasColumnName("MSDate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
