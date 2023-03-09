namespace QairService.Models
{
    public class QairInstance : QairBase
    {
        public QairInstance(string name, User owner) : base(name, owner)
        {
        }
        List<Answer>? Answers { get; set; }
        public void Assign(User user)
        {
            User = user;
        }

    }
}
