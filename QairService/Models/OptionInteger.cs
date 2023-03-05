namespace QairService.Models
{
    public class OptionInteger : Option<int>
    {
        public override int getValue()
        {
            return Value;
        }

        public override void setValue(int value)
        {
            Value = value;
        }
    }
}
