using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QairService.DB.Models
{
    [Table(name:"Answer")]
    public class AnswerDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(QairId))]
        public virtual QairInstanceDTO Qair { get; set; }
        public int? QairId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual UserDTO? User { get; set; }
        public int? UserId { get; set; }

        //[Required]
        //[ForeignKey(nameof(QuestionId))]
        //public virtual QuestionInstanceDTO Question{ get; set; }
        //public int? QuestionId { get; set; }
        
    }
}
