using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities;

public class BaseModel
{
    public string? Slug { get; set; }
    public bool IsActive { get; set; } = true;
    [Column(TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
