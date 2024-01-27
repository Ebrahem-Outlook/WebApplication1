using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name{ get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
