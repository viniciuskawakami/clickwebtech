using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities
{
    public class Project : BaseModel
    {
        [Key]
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string acronym { get; set; }
        [Required]
        public string Description { get; set; }
    }
    // TODO: Need include [Foreignkey]
}
