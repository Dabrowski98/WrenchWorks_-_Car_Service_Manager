using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class BodyColor
{
    public string Color { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
