using System.ComponentModel.DataAnnotations;

namespace SaudeLivre.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente{ get; set; }
        [Required]
        public string Nome{ get; set; }
        [Required]
        public string Cpf{ get; set; }
        [Required]
        public string Email{ get; set; }
    }
}