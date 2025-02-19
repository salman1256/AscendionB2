using System;
using System.Collections.Generic;

namespace ConAppEFCoreDbFirst.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public double? Mplan { get; set; }

    public DateOnly? Msdate { get; set; }

    public DateOnly? Medate { get; set; }
}
