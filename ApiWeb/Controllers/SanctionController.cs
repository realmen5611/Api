using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class SanctionController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Sanction.ToList();
            return Ok(list);
        }

        [HttpGet("{idSanction}")]
        public IActionResult GetById(int idSanction)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Sanction.FirstOrDefault(x => x.idSanction == idSanction);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(SanctionEntity sanctionEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Sanction.Add(sanctionEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(SanctionEntity sanctionEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Sanction.Update(sanctionEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idSanction}")]
        public IActionResult Delete(int idSanction)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Sanction.FirstOrDefault(x => x.idSanction == idSanction);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Sanction.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
