using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF008.ReverseEngineeringNETCLI.Entities;

public partial class Event
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndAt { get; set; }

    public int SpeakerId { get; set; }

    [ForeignKey("SpeakerId")]
    [InverseProperty("Events")]
    public virtual Speaker Speaker { get; set; }
}
