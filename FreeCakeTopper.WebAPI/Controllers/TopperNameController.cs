using System.Collections.Generic;
using System.Linq;
using FreeCakeTopper.WebAPI.Data;
using FreeCakeTopper.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreeCakeTopper.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopperNameController : ControllerBase
    {
        private readonly DataContext _context;
        public TopperNameController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetToppers()
        {
            return Ok(_context.TopperNames);
        }

        //api/user/byuserId?id=1 
        [HttpGet("byUserId")]
        public IActionResult GetByUserId(int userId)
        {
            // retornando apenas o primeiro
            var user = _context.TopperNames.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return BadRequest("Usuario não encontrado");
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post(TopperName topperName)
        {
            _context.Add(topperName);
            _context.SaveChanges();
            return Ok(topperName);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TopperName topperName)
        {

            var topper = _context.TopperNames.AsNoTracking().FirstOrDefault(t => t.Id == id);
            if (topper == null) return BadRequest("Nome não encontrado");

            _context.Update(topperName);
            _context.SaveChanges();
            return Ok(topperName);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, TopperName topperName)
        {

            var topper = _context.TopperNames.AsNoTracking().FirstOrDefault(t => t.Id == id);
            if (topper == null) return BadRequest("Nome não encontrado");

            _context.Update(topperName);
            _context.SaveChanges();
            return Ok(topperName);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var topper = _context.TopperNames.FirstOrDefault(t => t.Id == id);
            if (topper == null) return BadRequest("Nome não encontrado");

            _context.Remove(topper);
            _context.SaveChanges();
            return Ok(topper);

        }
    }
}