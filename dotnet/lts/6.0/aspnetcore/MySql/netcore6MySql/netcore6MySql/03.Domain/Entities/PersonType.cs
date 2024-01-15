using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities
{
    [Table("Person_Type")]
    public class PersonType : BaseModel
    {
        [Key]
        [Required]
        public int PersonTypeId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(64)]
        public string? Acronym { get; set; } = string.Empty;
        [Column(TypeName = "VARCHAR")]
        [StringLength(4000)]
        public string? Description { get; set; } = string.Empty;


    }
}
