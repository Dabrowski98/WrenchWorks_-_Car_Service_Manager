using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Part
{
    public long PartId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string? ManufacturerArtNo { get; set; }

    public string PartName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<TasksPart> TasksParts { get; } = new List<TasksPart>();
}
