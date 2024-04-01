using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace XayDungWebAphone.Models;

public partial class XayDungWebAphoneContext : DbContext
{
    public XayDungWebAphoneContext()
    {
    }

    public XayDungWebAphoneContext(DbContextOptions<XayDungWebAphoneContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetal> OrderDetals { get; set; }

    public virtual DbSet<Pay> Pays { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PHUT\\MSSQLSERVER01;Database=XayDungWebAphone;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.IdBill);

            entity.ToTable("Bill");

            entity.Property(e => e.IdBill).HasColumnName("Id_Bill");
            entity.Property(e => e.IdOrder).HasColumnName("Id_Order");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bill_Order");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory);

            entity.ToTable("Category");

            entity.Property(e => e.IdCategory).HasColumnName("Id_Category");
            entity.Property(e => e.NameCategory)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Name_Category");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.ToTable("Client");

            entity.Property(e => e.IdClient).HasColumnName("Id_Client");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order");

            entity.Property(e => e.IdOrder).HasColumnName("Id_Order");
            entity.Property(e => e.IdClient).HasColumnName("Id_Client");
            entity.Property(e => e.IdOrderDetals).HasColumnName("Id_OrderDetals");
            entity.Property(e => e.IdPay).HasColumnName("Id_Pay");
            entity.Property(e => e.IdUser).HasColumnName("Id_User");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Client");

            entity.HasOne(d => d.IdOrderDetalsNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdOrderDetals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderDetals");

            entity.HasOne(d => d.IdPayNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdPay)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Pay");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_User");
        });

        modelBuilder.Entity<OrderDetal>(entity =>
        {
            entity.HasKey(e => e.IdOrderDetals);

            entity.Property(e => e.IdOrderDetals).HasColumnName("Id_OrderDetals");
            entity.Property(e => e.IdBill).HasColumnName("Id_Bill");
            entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

            entity.HasOne(d => d.IdBillNavigation).WithMany(p => p.OrderDetals)
                .HasForeignKey(d => d.IdBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetals_Bill");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.OrderDetals)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetals_Product");
        });

        modelBuilder.Entity<Pay>(entity =>
        {
            entity.HasKey(e => e.IdPay);

            entity.ToTable("Pay");

            entity.Property(e => e.IdPay).HasColumnName("Id_Pay");
            entity.Property(e => e.Method)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct);

            entity.ToTable("Product");

            entity.Property(e => e.IdProduct).HasColumnName("Id_Product");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.IdCategory).HasColumnName("Id_Category");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Name_Product");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("User");

            entity.Property(e => e.IdUser).HasColumnName("Id_User");
            entity.Property(e => e.NameUser)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Name_User");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
