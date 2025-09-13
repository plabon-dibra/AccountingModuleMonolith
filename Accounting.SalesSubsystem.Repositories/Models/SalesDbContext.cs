using Microsoft.EntityFrameworkCore;
namespace Accounting.SalesSubsystem.Repositories.Models;

public partial class SalesDbContext : DbContext
{
    public SalesDbContext()
    {
    }

    public SalesDbContext(DbContextOptions<SalesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SalesLog> SalesLogs { get; set; }

    public virtual DbSet<SalesPerson> SalesPeople { get; set; }

    public virtual DbSet<SalesPersonUpdateLog> SalesPersonUpdateLogs { get; set; }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Tno);

            entity.HasIndex(e => e.BillContactId, "indx_Sales_BillingId");

            entity.HasIndex(e => e.Cid, "indx_Sales_CID");

            entity.HasIndex(e => e.Pcode, "indx_Sales_PCode");

            entity.Property(e => e.Tno).HasColumnName("TNO");
            entity.Property(e => e.AccReceivable).HasDefaultValue(0.0);
            entity.Property(e => e.BillContactId).HasComment("Id of Billing contact person");
            entity.Property(e => e.CashReceived).HasDefaultValue(0.0);
            entity.Property(e => e.Cid).HasColumnName("CId");
            entity.Property(e => e.Comments)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Edate)
                .HasComment("Ending date")
                .HasColumnType("smalldatetime")
                .HasColumnName("EDate");
            entity.Property(e => e.JciId).HasColumnName("JCI_ID");
            entity.Property(e => e.JpId).HasColumnName("JP_ID");
            entity.Property(e => e.Jsid)
                .HasDefaultValue(0)
                .HasComment("Job Seeker ID")
                .HasColumnName("JSID");
            entity.Property(e => e.Pcode).HasColumnName("PCode");
            entity.Property(e => e.Posted).HasComment("Posted to Journal");
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sdate)
                .HasComment("Starting date")
                .HasColumnType("smalldatetime")
                .HasColumnName("SDate");
            entity.Property(e => e.Tax)
                .HasDefaultValue(0.0)
                .HasComment("SalesTax(VAT/AID(Advance Income Tax))");
            entity.Property(e => e.TaxId).HasDefaultValue(0);
        });

        modelBuilder.Entity<SalesLog>(entity =>
        {
            entity.HasKey(e => e.SalesLogId).HasName("PK__SalesLog__CC6982C87CC51291");

            entity.ToTable("SalesLog");

            entity.Property(e => e.DeletedByUserId).HasColumnName("deletedByUserId");
            entity.Property(e => e.DeletedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("deletedDate");
            entity.Property(e => e.SalesByUserId).HasColumnName("SalesByUserID");
            entity.Property(e => e.SalesDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Tno).HasColumnName("TNO");
            entity.Property(e => e.UpdatedByUserId).HasColumnName("updatedByUserId");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<SalesPerson>(entity =>
        {
            entity.HasKey(e => e.SalesPersonId).HasName("PK_SalesPerson_SalesPersonID");

            entity.ToTable("SalesPerson");

            entity.Property(e => e.SalesPersonId)
                .ValueGeneratedNever()
                .HasColumnName("SalesPersonID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.SalesPersonName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Zone)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesPersonUpdateLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__SalesPer__5E548648283810E1");

            entity.ToTable("SalesPersonUpdateLog");

            entity.Property(e => e.ChangeReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CpId).HasColumnName("CP_ID");
            entity.Property(e => e.JpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JP_ID");
            entity.Property(e => e.PreviousSalesPersonName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalesPersonName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
