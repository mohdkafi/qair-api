using QairService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QairService.DB.Models
{
    [Table(name:"Option")]
    public class OptionDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Value { get; set; }
        [Required]
        public OptionType OptionType { get; set; }
        [ForeignKey(nameof(AnswerId))]
        public virtual AnswerDTO Answer { get; set; }
        public int? AnswerId { get; set; }
        [ForeignKey(nameof(QuestionId))]
        public virtual QuestionDTO Question { get; set; }
        public int? QuestionId { get; set; }
    }
}
