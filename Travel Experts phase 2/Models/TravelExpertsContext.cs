﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace travel_experts_phase_2.Models
{
    public partial class TravelExpertsContext : DbContext
    {
        public TravelExpertsContext()
        {
        }

        public TravelExpertsContext(DbContextOptions<TravelExpertsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Affiliation> Affiliations { get; set; } = null!;
        public virtual DbSet<Agency> Agencies { get; set; } = null!;
        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<BookingDetail> BookingDetails { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<CreditCard> CreditCards { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomersReward> CustomersRewards { get; set; } = null!;
        public virtual DbSet<DesktopAccount> DesktopAccounts { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Fee> Fees { get; set; } = null!;
        public virtual DbSet<Package> Packages { get; set; } = null!;
        public virtual DbSet<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductsPackage> ProductsPackages { get; set; } = null!;
        public virtual DbSet<ProductsSupplier> ProductsSuppliers { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Reward> Rewards { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SupplierContact> SupplierContacts { get; set; } = null!;
        public virtual DbSet<TripType> TripTypes { get; set; } = null!;
        public virtual DbSet<VwPackageProduct> VwPackageProducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True; TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affiliation>(entity =>
            {
                entity.HasKey(e => e.AffilitationId)
                    .HasName("aaaaaAffiliations_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK_Agents_Agencies");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("aaaaaBookings_PK")
                    .IsClustered(false);

                entity.Property(e => e.Balance).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PackageId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentStatus).HasDefaultValueSql("('Pending')");

                entity.Property(e => e.TotalPaid).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Bookings_FK00");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("Bookings_FK01");

                entity.HasOne(d => d.TripType)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.TripTypeId)
                    .HasConstraintName("Bookings_FK02");
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingDetailId)
                    .HasName("aaaaaBookingDetails_PK")
                    .IsClustered(false);

                entity.Property(e => e.BookingId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductSupplierId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_BookingDetails_Bookings");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_BookingDetails_Classes");

                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.FeeId)
                    .HasConstraintName("FK_BookingDetails_Fees");

                entity.HasOne(d => d.ProductSupplier)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.ProductSupplierId)
                    .HasConstraintName("FK_BookingDetails_Products_Suppliers");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_BookingDetails_Regions");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("aaaaaClasses_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasKey(e => e.CreditCardId)
                    .HasName("aaaaaCreditCards_PK")
                    .IsClustered(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CreditCards)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CreditCards_FK00");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("aaaaaCustomers_PK")
                    .IsClustered(false);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_Customers_Agents");
            });

            modelBuilder.Entity<CustomersReward>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.RewardId })
                    .HasName("aaaaaCustomers_Rewards_PK")
                    .IsClustered(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomersRewards)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Customers_Rewards_FK00");

                entity.HasOne(d => d.Reward)
                    .WithMany(p => p.CustomersRewards)
                    .HasForeignKey(d => d.RewardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Customers_Rewards_FK01");
            });

            modelBuilder.Entity<DesktopAccount>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__DesktopA__1788CC4C19718CDE");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.DesktopAccounts)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_Users_Admins");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.DesktopAccounts)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_Users_Agents");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DesktopAccounts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Users_Customers");
            });

            modelBuilder.Entity<Fee>(entity =>
            {
                entity.HasKey(e => e.FeeId)
                    .HasName("aaaaaFees_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasKey(e => e.PackageId)
                    .HasName("aaaaaPackages_PK")
                    .IsClustered(false);

                entity.Property(e => e.PkgAgencyCommission).HasDefaultValueSql("((0.0))");
            });

            modelBuilder.Entity<PackagesProductsSupplier>(entity =>
            {
                entity.HasKey(e => e.PackageProductSupplierId)
                    .HasName("PK__Packages__53E8ED99503AC85D");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackagesProductsSuppliers)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Packages_Products_Supplie_FK00");

                entity.HasOne(d => d.ProductSupplier)
                    .WithMany(p => p.PackagesProductsSuppliers)
                    .HasForeignKey(d => d.ProductSupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Packages_Products_Supplie_FK01");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("aaaaaProducts_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<ProductsPackage>(entity =>
            {
                entity.HasKey(e => e.ProductPackageId)
                    .HasName("PK_ProductPackage");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.ProductsPackages)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_Packages");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsPackages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products");
            });

            modelBuilder.Entity<ProductsSupplier>(entity =>
            {
                entity.HasKey(e => e.ProductSupplierId)
                    .HasName("aaaaaProducts_Suppliers_PK")
                    .IsClustered(false);

                entity.Property(e => e.ProductId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsSuppliers)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("Products_Suppliers_FK00");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProductsSuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("Products_Suppliers_FK01");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("aaaaaRegions_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.HasKey(e => e.RewardId)
                    .HasName("aaaaaRewards_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("aaaaaSuppliers_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<SupplierContact>(entity =>
            {
                entity.HasKey(e => e.SupplierContactId)
                    .HasName("aaaaaSupplierContacts_PK")
                    .IsClustered(false);

                entity.Property(e => e.SupplierContactId).ValueGeneratedNever();

                entity.Property(e => e.SupplierId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Affiliation)
                    .WithMany(p => p.SupplierContacts)
                    .HasForeignKey(d => d.AffiliationId)
                    .HasConstraintName("SupplierContacts_FK00");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierContacts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("SupplierContacts_FK01");
            });

            modelBuilder.Entity<TripType>(entity =>
            {
                entity.HasKey(e => e.TripTypeId)
                    .HasName("aaaaaTripTypes_PK")
                    .IsClustered(false);
            });

            modelBuilder.Entity<VwPackageProduct>(entity =>
            {
                entity.ToView("vw_PackageProducts");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
