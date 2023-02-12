using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class FuelType
{
    public string FuelType1 { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
