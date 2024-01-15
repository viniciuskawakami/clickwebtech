using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcore6MySql._03.Domain.Entities
{
    public class Person : BaseModel  
    {
        [Key]
        [Required]
        public Guid PersonId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [ForeignKey("DocumentType")]
        [Required]
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(64)]
        public string DocumentNumber { get; set; }
        [ForeignKey("PersonType")]
        [Required]
        public int PersonTypeId { get; set; }
        public virtual PersonType PersonType { get; set; }
        [ForeignKey("GenderIdentity")]
        public int GenderIdentityId { get; set; }
        public virtual GenderIdentity GenderIdentity { get; set; }
        public string? NickName { get; set; } = string.Empty;
        public string? SocialName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;

        // TODO: Need include [Foreignkey]
    }
}
