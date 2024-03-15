using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class DolshnostController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Dolshnost.ToList();
            return Ok(list);
        }

        [HttpGet("{idDolshnost}")]
        public IActionResult GetById(int idDol)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Dolshnost.FirstOrDefault(x => x.idDolshnost == idDol);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(DolshnostEntity dolshEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Dolshnost.Add(dolshEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(DolshnostEntity dolshEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Dolshnost.Update(dolshEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idDolshnost}")]
        public IActionResult Delete(int idDolsh)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Dolshnost.FirstOrDefault(x => x.idDolshnost == idDolsh);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Dolshnost.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
