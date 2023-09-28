using System;
namespace BackOffice.API.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string AkaName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string SocialName { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public DateTime EmailVerifiedAt { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string mobile { get; set; }
        public bool IsActive{get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        
        
        
    }
}