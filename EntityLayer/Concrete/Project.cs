using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    // Projeler
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}
