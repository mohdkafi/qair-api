namespace QairService.Models
{
    public class Qair
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public User? User { get; set; }

        public Qair(string name)
        {
            Name = name;
        }

        public void Assign(User user)
        {
            User = user;
        }

    }
}
