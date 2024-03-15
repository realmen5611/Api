using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class UsersEntity
    {
        [Key]

        public int idUsers { get; set; }
        public int idRole { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public RoleEntity Role { get; set; }
    }
}
