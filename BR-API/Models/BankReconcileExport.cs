using System;
using System.Collections.Generic;

namespace BR_API.Models;

public partial class BankReconcileExport
{
    public int TransationJournalId { get; set; }

    public int TransationId { get; set; }

    public string JournalBatchNumber { get; set; } = null!;

    public string InvoiceId { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public decimal? CreditAmount { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedByUser { get; set; }

    public string? ErrorMessage { get; set; }
}
