using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace QairService.Models
{
    public class Option 
    {
        public string? Value { get; set; }
        public OptionType OptionType { get; set; }

    }
}