﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DataBaseLayout.Models;
[PrimaryKey(nameof(Id))]

public class Booking
{
    public Guid Id { get; set; }

    [Required]
    public User User { get; set; }

    public virtual ICollection<PlaneSeat> PlaneSeat { get; set; }
}