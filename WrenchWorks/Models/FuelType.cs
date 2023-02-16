using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class FuelType
{
    public string Fuel { get; set; } = null!;

    public virtual ICollection<PowerSource> PowerSources { get; } = new List<PowerSource>();
}
