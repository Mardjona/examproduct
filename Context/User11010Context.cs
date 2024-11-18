using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using productex1.Models;

namespace productex1.Context;

public partial class User11010Context : DbContext
{
    public User11010Context()
    {
    }

    public User11010Context(DbContextOptions<User11010Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Suplaier> Suplaiers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Database = user11010; Username = user11010; Port = 5432; Password = 99583; Host = 192.168.7.159");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("product_pk");

            entity.ToTable("product", "demoexz");

            entity.Property(e => e.Productid)
                .ValueGeneratedNever()
                .HasColumnName("productid");
            entity.Property(e => e.Currentdiscouint).HasColumnName("currentdiscouint");
            entity.Property(e => e.Img)
                .HasColumnType("character varying")
                .HasColumnName("img");
            entity.Property(e => e.Productarticle)
                .HasColumnType("character varying")
                .HasColumnName("productarticle");
            entity.Property(e => e.Productcategory)
                .HasColumnType("character varying")
                .HasColumnName("productcategory");
            entity.Property(e => e.Productcost).HasColumnName("productcost");
            entity.Property(e => e.Productdescription)
                .HasColumnType("character varying")
                .HasColumnName("productdescription");
            entity.Property(e => e.Productdiscountamount).HasColumnName("productdiscountamount");
            entity.Property(e => e.Productmanufacturer)
                .HasColumnType("character varying")
                .HasColumnName("productmanufacturer");
            entity.Property(e => e.Productname)
                .HasColumnType("character varying")
                .HasColumnName("productname");
            entity.Property(e => e.Productquantityinstock).HasColumnName("productquantityinstock");
            entity.Property(e => e.Productstatus).HasColumnName("productstatus");
            entity.Property(e => e.SuplaiersId).HasColumnName("suplaiers_id");

            entity.HasOne(d => d.Suplaiers).WithMany(p => p.Products)
                .HasForeignKey(d => d.SuplaiersId)
                .HasConstraintName("product_suplaiers_fk");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("role_pk");

            entity.ToTable("Role", "demoexz");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.Rolename)
                .HasColumnType("character varying")
                .HasColumnName("rolename");
        });

        modelBuilder.Entity<Suplaier>(entity =>
        {
            entity.HasKey(e => e.SumpaiersId).HasName("suplaiers_pk");

            entity.ToTable("suplaiers", "demoexz");

            entity.Property(e => e.SumpaiersId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("sumpaiers_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("user_pk");

            entity.ToTable("user", "demoexz");

            entity.Property(e => e.UserId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("user_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Userlogin).HasColumnName("userlogin");
            entity.Property(e => e.Username)
                .HasColumnType("character varying")
                .HasColumnName("username");
            entity.Property(e => e.Userpassword).HasColumnName("userpassword");
            entity.Property(e => e.Userpatronymic)
                .HasColumnType("character varying")
                .HasColumnName("userpatronymic");
            entity.Property(e => e.Usersurname)
                .HasColumnType("character varying")
                .HasColumnName("usersurname");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("user_role_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
