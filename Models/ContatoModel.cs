using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_login_mvc.Models
{
    [Table("contatos")]
    public class ContatoModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Esta campo e obrigatorio")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Esta campo e obrigatorio")]
        public string email { get; set; }

        [Required(ErrorMessage = "Esta campo e obrigatorio")]
        public string celular { get; set; }
    }
}
