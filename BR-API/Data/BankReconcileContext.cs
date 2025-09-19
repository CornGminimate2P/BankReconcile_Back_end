using System;
using System.Collections.Generic;
using BR_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BR_API.Data;

public partial class BankReconcileContext : DbContext
{
    public BankReconcileContext()
    {
    }

    public BankReconcileContext(DbContextOptions<BankReconcileContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BankReconcileCpt> BankReconcileCpts { get; set; }

    public virtual DbSet<BankReconcileExport> BankReconcileExports { get; set; }

    public virtual DbSet<BankReconcileImport> BankReconcileImports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankReconcileCpt>(entity =>
        {
            entity.HasKey(e => e.ReconcileId).HasName("PK_BillReconcileClientPortal_1");

            entity.ToTable("BankReconcile_CPT");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClientName).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserName).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(15);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.D365invoiceNumber)
                .HasMaxLength(15)
                .HasColumnName("D365InvoiceNumber");
            entity.Property(e => e.DateCreated).HasPrecision(0);
            entity.Property(e => e.DateIsPost).HasPrecision(0);
            entity.Property(e => e.DateTransaction).HasPrecision(0);
            entity.Property(e => e.DepositToBank).HasMaxLength(30);
            entity.Property(e => e.InvoiceId).HasMaxLength(15);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(20);
            entity.Property(e => e.PaymentGateway).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypePost).HasMaxLength(20);
            entity.Property(e => e.WhtDiscount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<BankReconcileExport>(entity =>
        {
            entity.HasKey(e => new { e.TransationJournalId, e.TransationId, e.JournalBatchNumber, e.InvoiceId }).HasName("PK_BillReconcileTransfer");

            entity.ToTable("BankReconcile_Export");

            entity.Property(e => e.TransationJournalId).ValueGeneratedOnAdd();
            entity.Property(e => e.JournalBatchNumber).HasMaxLength(20);
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(20)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedByUser).HasMaxLength(40);
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerCode).HasMaxLength(20);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasPrecision(0);
            entity.Property(e => e.ErrorMessage).HasMaxLength(50);
        });

        modelBuilder.Entity<BankReconcileImport>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.EffectiveDate, e.BankName });

            entity.ToTable("BankReconcile_Import");

            entity.Property(e => e.TransactionId).ValueGeneratedOnAdd();
            entity.Property(e => e.EffectiveDate).HasPrecision(0);
            entity.Property(e => e.BankName).HasMaxLength(10);
            entity.Property(e => e.AccountCode).HasMaxLength(15);
            entity.Property(e => e.AccountName).HasMaxLength(20);
            entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BranchName).HasMaxLength(20);
            entity.Property(e => e.ChequeNumber).HasMaxLength(10);
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EffectiveTime).HasPrecision(0);
            entity.Property(e => e.TransactionBranch).HasMaxLength(10);
            entity.Property(e => e.TransactionChannel).HasMaxLength(40);
            entity.Property(e => e.TransactionDate).HasPrecision(0);
            entity.Property(e => e.TransactionDescription).HasMaxLength(100);
            entity.Property(e => e.TransactionNumber).HasMaxLength(10);
            entity.Property(e => e.TransactionType).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
