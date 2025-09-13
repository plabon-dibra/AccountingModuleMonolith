using System;
using System.Collections.Generic;

namespace Accounting.CustomerSubsystem.Repositories.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Fax { get; set; }

    public string ContactPerson { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public double Balance { get; set; }

    public bool BlackListed { get; set; }

    public int CpId { get; set; }

    public string? AccContactName { get; set; }

    public string? VatregNo { get; set; }

    public string? VatregAdd { get; set; }

    public short? DistrictId { get; set; }

    public int? UpazilaId { get; set; }

    public short? BankId { get; set; }

    public string? VatChallanName { get; set; }

    public DateTime? PostedOn { get; set; }

    public string? AccPersonMail { get; set; }

    public string? AccPersonContactNo { get; set; }

    public bool? AnyVatExemption { get; set; }

    public string? VatExemptionReason { get; set; }

    public bool? CustomizeRate { get; set; }

    public bool? AutoMail { get; set; }

    public string? Remarks { get; set; }

    public int? CreditPeriod { get; set; }
}
