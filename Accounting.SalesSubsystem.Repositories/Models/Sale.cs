using System;
using System.Collections.Generic;

namespace Accounting.SalesSubsystem.Repositories.Models;

public partial class Sale
{
    public int Tno { get; set; }

    public int Pcode { get; set; }

    public int Cid { get; set; }

    /// <summary>
    /// Starting date
    /// </summary>
    public DateTime Sdate { get; set; }

    /// <summary>
    /// Ending date
    /// </summary>
    public DateTime? Edate { get; set; }

    public double SalesPrice { get; set; }

    public double? CashReceived { get; set; }

    public double? AccReceivable { get; set; }

    public string? Comments { get; set; }

    public int Duration { get; set; }

    public short NumberOfInvoices { get; set; }

    /// <summary>
    /// Posted to Journal
    /// </summary>
    public bool Posted { get; set; }

    /// <summary>
    /// Id of Billing contact person
    /// </summary>
    public int BillContactId { get; set; }

    /// <summary>
    /// SalesTax(VAT/AID(Advance Income Tax))
    /// </summary>
    public double? Tax { get; set; }

    public string? RefNo { get; set; }

    public int? TaxId { get; set; }

    public int? SalesPerson { get; set; }

    /// <summary>
    /// Job Seeker ID
    /// </summary>
    public int? Jsid { get; set; }

    public int? JpId { get; set; }

    public int? JciId { get; set; }

    public bool? Invalid { get; set; }
}
