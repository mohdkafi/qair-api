using QairService.DB.Models;

namespace QairService.Models
{
    public class Qair : QairBase
    {
        List<Question>? Questions {get; set;}
        public Qair(string name,User owner) : base(name,  owner )
        {
        }
        public QairDTO Map()
        {
            var qair = new QairDTO
            {
                Id = Id,
                Name = Name,
                //Owner = Owner,
                //User = User
            };
            return qair;
        }
    }
}
