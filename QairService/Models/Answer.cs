namespace QairService.Models
{
    public class Answer 
    {
        public int Id { get; set; }
        public QairInstance Qair { get; set; }
        public User? User { get; set; }
        public Question Question { get; set; }
        public List<Option>? Options { get; set; }
        public Answer(QairInstance qair,Question question)
        {
            Qair = qair;
            Question = question;
        }
        public void SubmitAnswer(User user, List<Option> options)
        {
            User = user;
            Options = options;
        }

        
    }
}