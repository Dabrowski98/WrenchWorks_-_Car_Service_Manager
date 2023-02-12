using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Part
{
    public long PartId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public long? ManufacturerArtNo { get; set; }

    public string PartName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();
}
