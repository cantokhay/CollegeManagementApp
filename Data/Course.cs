using System;
using System.Collections.Generic;

namespace CollegeManagementApp.Data;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public int? Credits { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
