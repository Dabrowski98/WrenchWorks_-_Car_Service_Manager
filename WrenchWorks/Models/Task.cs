using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Task
{
    public long TaskId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public float ExecutionTime { get; set; }

    public long ServiceId { get; set; }

    public virtual Service Service { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Part> Parts { get; } = new List<Part>();
}
