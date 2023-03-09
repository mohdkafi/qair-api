namespace QairService.Models
{
    public class QairBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public User? User { get; set; }

        public QairBase(string name, User owner)
        {
            Name = name;
            Owner = owner;
        }
    }
}
