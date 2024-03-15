using System.ComponentModel.DataAnnotations;

namespace ApiWeb.Model
{
    public class NarusheniaEmpEntity
    {
        [Key]

        public int idNarusheniaEmp { get; set; }
        public int idEmployee { get; set; }
        public string NarusheniaEmp { get; set; }
    }
}
