namespace QairService.Models
{
    public class Qair : QairBase
    {
        List<Question>? Questions {get; set;}
        public Qair(string name,User owner) : base(name,  owner )
        {
        }
    }
}
