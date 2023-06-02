using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchuldatenDBShared;

[Table("OfficeAssignment")]
public partial class OfficeAssignment
{
    [Key]
    [Column("InstructorID")]
    public long InstructorId { get; set; }

    public string? Location { get; set; }

    [ForeignKey("InstructorId")]
    [InverseProperty("OfficeAssignment")]
    public virtual Person Instructor { get; set; } = null!;
}
