using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities
{
    [Table("Gender_identity")]
    public class GenderIdentity  : BaseModel
    {
        [Key]
        [Required]
        public int GenderIdentityId { get; set; }
        [Required]
        public string Acronym { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
