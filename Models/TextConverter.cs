using System;

namespace simple_mvvm_example.Models
{
    public class TextConverter
    {
        private readonly Func<string, string> convertion;

        public TextConverter(Func<string, string> convertion)
        {
            this.convertion = convertion;
        }

        public string ConvertText(string inputText)
        {
            return convertion(inputText);
        }
    }
}
