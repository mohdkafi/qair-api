namespace QairService.Models
{
    public class Answer<T>
    {
        public int Id { get; set; }
        public Qair Qair { get; set; }
        public User? User { get; set; }
        public Question<T> Question { get; set; }
        public List<Option<T>>? Options { get; set; }
        public Answer(Qair qair, Question<T> question)
        {
            Qair = qair;
            Question = question;
        }
        public void SubmitAnswer(List<Option<T>> options)
        {
            Options = options;
        }
    }
}
