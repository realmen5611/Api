using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class PolEntity
    {
        [Key]

        public int idPol { get; set; }
        public string Pol { get; set; }
    }
}
