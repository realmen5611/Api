using ApiWeb.DTO;
using ApiWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Users
                .Include(u => u.Role).ToList();
            return Ok(list);
        }

        [HttpPost("/login")]
        public IActionResult Login(UserLoginDTO dto)
        {
            using ApplicationContext _context = new ApplicationContext();
            UsersEntity? user = _context.Users.Include(u => u.Role).FirstOrDefault(x => x.Login.ToLower() == dto.Login.ToLower());
            if (user == null)
            {
                return BadRequest();
            }
            if (user.Password != dto.Password)
            {
                return BadRequest();
            }
            return Ok(user);
        }

        [HttpGet("{idUser}")]
        public IActionResult GetById(int idUser)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Users.Include(u => u.Role).FirstOrDefault(x => x.idUsers == idUser);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(UsersEntity taskEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Users.Add(taskEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(UsersEntity taskEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Users.Update(taskEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idUser}")]
        public IActionResult Delete(int idUser)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Users.FirstOrDefault(x => x.idUsers == idUser);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Users.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
