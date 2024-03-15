using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class NarusheteliController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Narusheteli.ToList();
            return Ok(list);
        }

        [HttpGet("{idNarusheteli}")]
        public IActionResult GetById(int idNarushiteli)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Narusheteli.FirstOrDefault(x => x.idNarusheteli == idNarushiteli);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(NarusheteliEntity narushiteliEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Narusheteli.Add(narushiteliEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(NarusheteliEntity narushiteliEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Narusheteli.Update(narushiteliEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idNarusheteli}")]
        public IActionResult Delete(int idNarushiteli)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Narusheteli.FirstOrDefault(x => x.idNarusheteli == idNarushiteli);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Narusheteli.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
