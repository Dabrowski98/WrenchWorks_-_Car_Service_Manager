using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Position
{
    public string Position1 { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
