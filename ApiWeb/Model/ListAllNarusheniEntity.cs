using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class ListAllNarusheniEntity
    {
        [Key]

        public int idListAllNarusheni { get; set; }
        public int idEmployee { get; set; }
        public int idPrestuplenia { get; set; }
    }
}
