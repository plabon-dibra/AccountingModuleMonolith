using System;
using System.Collections.Generic;

namespace Accounting.SalesSubsystem.Repositories.Models;

public partial class SalesLog
{
    public int SalesLogId { get; set; }

    public int Tno { get; set; }

    public bool? IsManual { get; set; }

    public int SalesByUserId { get; set; }

    public DateTime SalesDate { get; set; }

    public int? UpdatedByUserId { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? DeletedByUserId { get; set; }

    public DateTime? DeletedDate { get; set; }
}
