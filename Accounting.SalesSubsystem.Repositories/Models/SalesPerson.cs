using System;
using System.Collections.Generic;

namespace Accounting.SalesSubsystem.Repositories.Models;

public partial class SalesPerson
{
    public int SalesPersonId { get; set; }

    public string SalesPersonName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string? Zone { get; set; }

    public int? EmployeeId { get; set; }
}
