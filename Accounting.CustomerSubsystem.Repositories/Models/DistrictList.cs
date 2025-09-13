using System;
using System.Collections.Generic;

namespace Accounting.CustomerSubsystem.Repositories.Models;

public partial class DistrictList
{
    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public string? DistrictNameBn { get; set; }

    public int? OnlineId { get; set; }
}
