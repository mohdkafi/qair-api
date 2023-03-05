namespace QairService.Models
{
    public class OptionString : Option<string>
    {

        public override string getValue()
        {
            return Value?? string.Empty;
        }

        public override void setValue(string value)
        {
            Value = value;
        }
    }
}
