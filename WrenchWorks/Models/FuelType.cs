using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class FuelType
{
    public string FuelType1 { get; set; } = null!;

    public virtual ICollection<PowerSource> PowerSources { get; } = new List<PowerSource>();
}
