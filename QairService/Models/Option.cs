using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace QairService.Models
{
    public abstract class Option<T>
    {
        protected T? Value;
        public abstract void setValue(T value);
        public abstract T getValue();
    }
}