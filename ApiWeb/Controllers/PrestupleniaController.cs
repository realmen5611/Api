using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class PrestupleniaController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Prestuplenia.ToList();
            return Ok(list);
        }

        [HttpGet("{idPrestuplenia}")]
        public IActionResult GetById(int idPrestuplenia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Prestuplenia.FirstOrDefault(x => x.idPrestuplenia == idPrestuplenia);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(PrestupleniaEntity prestupleniaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Prestuplenia.Add(prestupleniaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(PrestupleniaEntity prestupleniaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Prestuplenia.Update(prestupleniaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idPrestuplenia}")]
        public IActionResult Delete(int idPrestuplenia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Prestuplenia.FirstOrDefault(x => x.idPrestuplenia == idPrestuplenia);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Prestuplenia.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
