using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    // günün sözü
    public class Quote
    {
        [Key]
        public int QuoteID { get; set; }
        public string Text { get; set; }
        public string Person { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
