using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities
{
    public class Client : BaseModel
    {
        [Key]
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string acronym { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
    
}
