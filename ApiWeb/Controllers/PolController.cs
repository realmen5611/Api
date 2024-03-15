using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class PolController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Pol.ToList();
            return Ok(list);
        }

        [HttpGet("{idPol}")]
        public IActionResult GetById(int idPol)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Pol.FirstOrDefault(x => x.idPol == idPol);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(PolEntity polEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Pol.Add(polEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(PolEntity polEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Pol.Update(polEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idPol}")]
        public IActionResult Delete(int idPol)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Pol.FirstOrDefault(x => x.idPol == idPol);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Pol.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
