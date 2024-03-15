using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class SanctionEntity
    {
        [Key]

        public int idSanction { get; set; }
        public string Sanction { get; set; }
    }
}
