using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class NarusheteliEntity
    {
        [Key]

        public int idNarusheteli { get; set; }
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public int idSanction { get; set; }
        public int idPrestuplenia { get; set; }
    }
}
