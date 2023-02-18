using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Person
{
    public long PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string TelephoneNumber { get; set; } = null!;

    public string? Email { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
