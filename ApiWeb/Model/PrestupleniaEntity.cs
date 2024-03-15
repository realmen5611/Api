using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class PrestupleniaEntity
    {
        [Key]

        public int idPrestuplenia { get; set; }
        public int idVidPrestuplenia { get; set; }
        public string Prestuplenia { get; set; }
        public bool Vipolnenie { get; set; }
    }
}
