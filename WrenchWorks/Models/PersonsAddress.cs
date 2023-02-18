using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class PersonsAddress
{
    public long PersonId { get; set; }

    public long AddressId { get; set; }
    
    public virtual Address Address { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
