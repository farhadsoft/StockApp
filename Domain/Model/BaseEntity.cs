﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
