using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Position
{
    public short PositionId { get; set; }

    public short? SupervisorId { get; set; }

    public string PositionName { get; set; } = null!;

    public decimal ServiceHourRate { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Position> InverseSupervisor { get; } = new List<Position>();

    public virtual Position? Supervisor { get; set; }
}
