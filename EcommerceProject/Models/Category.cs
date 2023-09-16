using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public Category()
        {
            Name = "";
            DisplayOrder = 0;
        }
    }
}
