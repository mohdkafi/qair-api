using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QairService.DB.Models
{
    [Table(name:"QairInstance")]
    public class QairInstanceDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(OwnerId))]
        public virtual UserDTO Owner { get; set; }
        public int? OwnerId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual UserDTO? User { get; set; }
        public int? UserId { get; set; }
        public virtual ICollection<AnswerDTO> Answers { get;} 
    }
}
