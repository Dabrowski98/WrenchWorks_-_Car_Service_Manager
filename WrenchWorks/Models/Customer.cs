using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Customer
{
    public long CustomerId { get; set; }

    public string? Nip { get; set; }

    public virtual Person CustomerNavigation { get; set; } = null!;

    public virtual ICollection<Service> Services { get; } = new List<Service>();
}
