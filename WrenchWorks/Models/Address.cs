using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Address
{
    public long AddressId { get; set; }

    public string Region { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Street { get; set; }

    public string BuildingNo { get; set; } = null!;

    public string? FlatNo { get; set; }

    public string PostCode { get; set; } = null!;

    public virtual ICollection<Person> People { get; } = new List<Person>();
}
