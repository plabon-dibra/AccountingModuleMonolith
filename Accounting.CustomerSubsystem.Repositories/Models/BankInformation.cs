using System;
using System.Collections.Generic;

namespace Accounting.CustomerSubsystem.Repositories.Models;

public partial class BankInformation
{
    public short BankId { get; set; }

    public string AccountTitle { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string? BranchName { get; set; }

    public string BankAcno { get; set; } = null!;

    public string? BankRoutingNo { get; set; }

    public string? SwiftCode { get; set; }

    public string? Email { get; set; }
}
