namespace netcore6MySql._03.Domain.Entities;

public class BaseModel
{
    public string Slug { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}
