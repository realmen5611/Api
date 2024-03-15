using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class NarusheniaEmpController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.NarusheniaEmp.ToList();
            return Ok(list);
        }

        [HttpGet("{idNarusheniaEmp}")]
        public IActionResult GetById(int idNarusheniaEmp)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.NarusheniaEmp.FirstOrDefault(x => x.idNarusheniaEmp == idNarusheniaEmp);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(NarusheniaEmpEntity NarusheniaEmpEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.NarusheniaEmp.Add(NarusheniaEmpEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(NarusheniaEmpEntity NarusheniaEmpEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.NarusheniaEmp.Update(NarusheniaEmpEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idNarusheniaEmp}")]
        public IActionResult Delete(int idNarusheniaEmp)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.NarusheniaEmp.FirstOrDefault(x => x.idNarusheniaEmp == idNarusheniaEmp);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.NarusheniaEmp.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
