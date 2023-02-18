using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class TasksPart
{
    public long TaskId { get; set; }

    public long PartId { get; set; }

    public virtual Part Part { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
