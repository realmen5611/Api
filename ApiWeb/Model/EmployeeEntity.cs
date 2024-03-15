using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class EmployeeEntity
    {
        [Key]

        public int idEmployee { get; set; }
        public int idUsers { get; set; }
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string TelephoneNumber { get; set; }
        public int idPol { get; set; }
        public int idDolshnost { get; set; }
        //public PolEntity Pol { get; set; }
    }
}
