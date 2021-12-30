using System.ComponentModel.DataAnnotations;

namespace SaudeLivre.Models
{
    public class Blog
    {
        [Key]
        public int IdBlog{ get; set; }
        [Required]
        public string Titulo{ get; set; }
        [Required]
        public string TextoInicial{ get; set; }
        [Required]
        public string TextoSecundario{ get; set; }
        [Required]
        public string ImagemInicial{ get; set; }
        [Required]
        public string ImagemSecundaria{ get; set; }
    }
}