using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QairService.DB.Models
{
    [Table(name:"User")]
    internal class UserDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public string Email { get; set; } 
        public string Password { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } 
        public bool PasswordConfirmed { get; set; }
    }
}
