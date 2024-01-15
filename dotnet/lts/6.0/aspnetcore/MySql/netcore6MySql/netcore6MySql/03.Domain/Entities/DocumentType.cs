using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities
{
    [Table("Document_Type")]
    public class DocumentType :BaseModel
    {
        [Key]
        [Required]
        public int DocumentTypeId { get; set; }
        [Required]
        public string Acronym { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
