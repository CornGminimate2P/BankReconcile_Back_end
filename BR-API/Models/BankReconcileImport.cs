using System;
using System.Collections.Generic;

namespace BR_API.Models;

public partial class BankReconcileImport
{
    public int TransactionId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? BranchName { get; set; }

    public DateTime EffectiveDate { get; set; }

    public TimeOnly? EffectiveTime { get; set; }

    public string? TransactionType { get; set; }

    public string BankName { get; set; } = null!;

    public string? ChequeNumber { get; set; }

    public decimal? DebitAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? BalanceAmount { get; set; }

    public string? TransactionNumber { get; set; }

    public string? TransactionBranch { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionChannel { get; set; }

    public string? TransactionDescription { get; set; }
}
