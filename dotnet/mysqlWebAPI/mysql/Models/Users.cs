using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace mysql.Models
{
    public class Users
    {
        [PrimaryKey]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile { get; set; }

    }
}
