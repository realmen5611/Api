using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class RoleController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Role.ToList();
            return Ok(list);
        }

        [HttpGet("{idRole}")]
        public IActionResult GetById(int idRole)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Role.FirstOrDefault(x => x.idRole == idRole);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(RoleEntity roleEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Role.Add(roleEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(RoleEntity roleEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Role.Update(roleEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idRole}")]
        public IActionResult Delete(int idRole)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Role.FirstOrDefault(x => x.idRole == idRole);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Role.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
