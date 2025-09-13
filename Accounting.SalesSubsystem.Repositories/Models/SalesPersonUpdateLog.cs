using System;
using System.Collections.Generic;

namespace Accounting.SalesSubsystem.Repositories.Models;

public partial class SalesPersonUpdateLog
{
    public int LogId { get; set; }

    public string JpId { get; set; } = null!;

    public int CpId { get; set; }

    public int SalesPersonId { get; set; }

    public string? SalesPersonName { get; set; }

    public int UpdatedById { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? PreviousSalesPersonId { get; set; }

    public string? PreviousSalesPersonName { get; set; }

    public string? ChangeReason { get; set; }
}
