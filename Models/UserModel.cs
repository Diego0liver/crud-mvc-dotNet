using crud_login_mvc.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_login_mvc.Models
{
    [Table("users")]
    public class UserModel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public PerfilUserEnum perfil { get; set; }
    }
}
