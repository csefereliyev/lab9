using System.ComponentModel.DataAnnotations;

namespace Helpdeskweb.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Oyun adı daxil edilməlidir")]
        [StringLength(100)]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Oyun haqqında təsvir daxil edilməlidir")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Janr seçilməlidir")]
        public string Genre { get; set; } = "";

        [Range(0, 1000, ErrorMessage = "Qiymət 0 ilə 1000 arasında olmalıdır")]
        public decimal Price { get; set; }

        [Range(0, 100)]
        public int DiscountPercent { get; set; } = 0;

        public string Platform { get; set; } = "PC";

        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
}
