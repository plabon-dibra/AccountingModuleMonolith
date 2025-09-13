using System;
using System.Collections.Generic;

namespace Accounting.CustomerSubsystem.Repositories.Models;

public partial class ContactPerson
{
    public int Id { get; set; }

    public int Cid { get; set; }

    public string Name { get; set; } = null!;

    public string? Designation { get; set; }

    public string Ptype { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
