using System;
using System.Collections.Generic;

namespace EF008.ReverseEngineering.Entities;

public partial class Speaker
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}
