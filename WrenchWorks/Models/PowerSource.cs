using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class PowerSource
{
    public string Vin { get; set; } = null!;

    public string MainPowerSourceType { get; set; } = null!;

    public bool Hybrid { get; set; }

    public bool Biofuel { get; set; }

    public bool Lpg { get; set; }

    public bool Cng { get; set; }

    public virtual FuelType MainPowerSourceTypeNavigation { get; set; } = null!;

    public virtual Vehicle? Vehicle { get; set; }
}
