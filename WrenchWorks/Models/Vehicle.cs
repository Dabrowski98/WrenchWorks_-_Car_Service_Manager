using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Vehicle
{
    public string Vin { get; set; } = null!;

    public string Maker { get; set; } = null!;

    public string Model { get; set; } = null!;

    public DateTime YearOfProduction { get; set; }

    public string? EngineCapacity { get; set; }

    public string PowerSource { get; set; } = null!;

    public string? EngineNo { get; set; }

    public string? BodyColor { get; set; }

    public long? PersonId { get; set; }

    public virtual BodyColor? BodyColorNavigation { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<Service> Services { get; } = new List<Service>();

    public virtual PowerSource VinNavigation { get; set; } = null!;
}
