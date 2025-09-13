using System;
using System.Collections.Generic;

namespace Accounting.CustomerSubsystem.Repositories.Models;

public partial class Upazila
{
    public int UpazilaId { get; set; }

    public short DistrictId { get; set; }

    public string UpazilaName { get; set; } = null!;

    public string? UpazilaNameBn { get; set; }
}
