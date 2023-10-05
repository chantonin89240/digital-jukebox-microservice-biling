using System.ComponentModel;

namespace Application.DTOs
{
    public class Card
    {
        [DefaultValue("1234567890123456")]
        public string Number { get; set; }

        [DefaultValue("123")]
        public string CVC { get; set; }

        [DefaultValue(1)]
        public int ExpMonth { get; set; }

        [DefaultValue(2025)]
        public int ExpYear { get; set; }
    }
}
