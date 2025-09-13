using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Accounting.CustomerSubsystem.Repositories.Models;

public partial class CustomerDbContext : DbContext
{
    public CustomerDbContext()
    {
    }

    public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BankInformation> BankInformations { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<ContactPerson> ContactPersons { get; set; }

    public virtual DbSet<DistrictList> DistrictLists { get; set; }

    public virtual DbSet<Upazila> Upazilas { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankInformation>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("BankInformation");

            entity.Property(e => e.BankId)
                .ValueGeneratedNever()
                .HasColumnName("BankID");
            entity.Property(e => e.AccountTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankAcno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankACNo");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankRoutingNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SwiftCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.HasIndex(e => e.BlackListed, "indx_Company_BlackListed");

            entity.HasIndex(e => e.Name, "indx_Company_Name");

            entity.Property(e => e.AccContactName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AccPersonContactNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.AccPersonMail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.BankId)
                .HasDefaultValue((short)1)
                .HasColumnName("BankID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Contact_Person");
            entity.Property(e => e.CpId).HasColumnName("CP_ID");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PostedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.UpazilaId).HasColumnName("UpazilaID");
            entity.Property(e => e.VatChallanName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VatExemptionReason)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.VatregAdd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VATRegAdd");
            entity.Property(e => e.VatregNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VATRegNo");
        });

        modelBuilder.Entity<ContactPerson>(entity =>
        {
            entity.HasIndex(e => e.Cid, "indx_ContactPersons_CID");

            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ptype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PType");
        });

        modelBuilder.Entity<DistrictList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DistrictList");

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DistrictNameBn)
                .HasMaxLength(60)
                .HasColumnName("DistrictNameBN");
            entity.Property(e => e.OnlineId).HasColumnName("Online_Id");
        });

        modelBuilder.Entity<Upazila>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.UpazilaId).HasColumnName("UpazilaID");
            entity.Property(e => e.UpazilaName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpazilaNameBn)
                .HasMaxLength(60)
                .HasColumnName("UpazilaNameBN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
