using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QairService.DB.Models
{
    [Table(name:"Question")]
    public class QuestionDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [ForeignKey(nameof(QairId))]
        public virtual QairDTO Qair { get; set; }
        public int? QairId { get; set; }
    }
}
