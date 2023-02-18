using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class TasksEmployee
{
    public long EmployeeId { get; set; }

    public long TaskId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
