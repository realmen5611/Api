using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class DolshnostEntity 
    {
        [Key]

        public int idDolshnost { get; set; }
        public string Dolshnost { get; set; }
    }
}
