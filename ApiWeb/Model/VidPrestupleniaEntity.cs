using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class VidPrestupleniaEntity
    {
        [Key]

        public int idVidPrestuplenia { get; set; }
        public string vidPrestuplenia { get; set; }
    }
}
