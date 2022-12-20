using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF008.ReverseEngineeringNETCLI.Entities;

public partial class Speaker
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(25)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(25)]
    public string LastName { get; set; }

    [InverseProperty("Speaker")]
    public virtual ICollection<Event> Events { get; } = new List<Event>();
}
