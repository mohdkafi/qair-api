namespace QairService.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        List<Option>? Options { get; set; }
    }
}