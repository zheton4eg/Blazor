﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models;

public partial class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int StudentId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public DateOnly BirthDate { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    //public byte[]? Photo { get; set; }

    public int? GroupId { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Group? GroupNavigation { get; set; }
}
