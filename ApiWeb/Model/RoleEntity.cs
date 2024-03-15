using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class RoleEntity
    {
        [Key]
        public int idRole { get; set; }
        public string Role { get; set; }
    }
}
