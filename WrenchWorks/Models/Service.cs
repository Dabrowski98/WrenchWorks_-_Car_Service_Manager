using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Service
{
    public long ServiceId { get; set; }

    public string? Vin { get; set; }

    public decimal? TotalCost { get; set; }

    public DateTime ServiceStartDate { get; set; }

    public DateTime? ServiceEndDate { get; set; }

    public long? CustomerId { get; set; }

    public long? EmployeeId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();

    public virtual Vehicle? VinNavigation { get; set; }
}
