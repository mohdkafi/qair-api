namespace QairService.Models
{
    public class Question<T>
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        List<Option<T>>? Options { get; set; }

        public Question()
        {
         Options = new List<Option<T>>();
        }
        public Question(List<Option<T>> options)
        {
            Options = options;
        }
    }
}