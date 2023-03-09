using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QairService.DB.Models
{
    [Table(name: "QuestionInstance")]

    internal class QuestionInstanceDTO
    {
            [Key]
            [Required]
            public int Id { get; set; }
            [Required]
            public string Text { get; set; }
            [ForeignKey(nameof(AnswerId))]
            public virtual AnswerDTO Answer { get; set; }
            public int? AnswerId { get; set; }
    }
}
