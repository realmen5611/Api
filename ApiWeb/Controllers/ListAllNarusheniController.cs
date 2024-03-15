using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class ListAllNarusheniController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.ListAllNarusheni.ToList();
            return Ok(list);
        }

        [HttpGet("{idListAllNarusheni}")]
        public IActionResult GetById(int idListAllNarusheni)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.ListAllNarusheni.FirstOrDefault(x => x.idListAllNarusheni == idListAllNarusheni);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(ListAllNarusheniEntity ListAllNarusheni)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.ListAllNarusheni.Add(ListAllNarusheni).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(ListAllNarusheniEntity ListAllNarusheni)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.ListAllNarusheni.Update(ListAllNarusheni).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idListAllNarusheni}")]
        public IActionResult Delete(int idListAllNarusheni)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.ListAllNarusheni.FirstOrDefault(x => x.idListAllNarusheni == idListAllNarusheni);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.ListAllNarusheni.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
