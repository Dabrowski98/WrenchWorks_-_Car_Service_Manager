using System;
using System.Collections.Generic;

namespace WrenchWorks.Models;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public DateTime DateOfEmployment { get; set; }

    public string PositionName { get; set; } = null!;

    public virtual Person EmployeeNavigation { get; set; } = null!;

    public virtual Position PositionNameNavigation { get; set; } = null!;

    public virtual ICollection<Service> Services { get; } = new List<Service>();

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();
}
