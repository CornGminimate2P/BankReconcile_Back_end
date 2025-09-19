using System;
using System.Collections.Generic;

namespace BR_API.Models;

public partial class BankReconcileCpt
{
    public int ReconcileId { get; set; }

    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? InvoiceId { get; set; }

    public string? DepositToBank { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string? D365invoiceNumber { get; set; }

    public decimal? Amount { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? WhtDiscount { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public DateTime DateTransaction { get; set; }

    public string? CreatedByUserName { get; set; }

    public string? PaymentGateway { get; set; }

    public string? Status { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? IsPost { get; set; }

    public DateTime? DateIsPost { get; set; }

    public string? TypePost { get; set; }
}
