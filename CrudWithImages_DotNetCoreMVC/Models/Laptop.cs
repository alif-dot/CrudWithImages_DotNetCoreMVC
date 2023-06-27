using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWithImages_DotNetCoreMVC.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? Path { get; set; }

        [NotMapped]
        [Display(Name = "Choose Image")]
        public IFormFile? ImagePath { get; set; }
    }
}
