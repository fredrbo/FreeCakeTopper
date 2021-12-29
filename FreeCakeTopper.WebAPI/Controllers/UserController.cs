using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FreeCakeTopper.WebAPI.Models;
using System.Linq;
using FreeCakeTopper.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace FreeCakeTopper.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository _repo;
        public UserController(IRepository repo
        )
        {
            _repo = repo;
        }

        //api/user
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllUsers();
            return Ok(result);
        }
        //api/user/byId?id=1 
        [HttpGet("byId")]
        public IActionResult GetById(int id)
        {

            var user = _repo.GetUserById(id);
            if (user == null) return BadRequest("Usuario não encontrado");
            return Ok(user);
        }

        // [HttpGet("ByName")]
        // public IActionResult GetByName(string name, string email)
        // {
        //     var user = _repo.Users.FirstOrDefault(u =>
        //     u.Name.Contains(name) && u.Email.Contains(email));
        //     if (user == null) return BadRequest("Usuario ou email não encontrado");

        //     return Ok(user);
        // }
        //api/user
        [HttpPost()]
        public IActionResult Post(User user)
        {
            _repo.Add(user);
            if (_repo.SaveChanges())
            {
                return Ok(user);
            }
            return BadRequest("Usuário não cadastrado");
        }

        //api/user/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, User user)
        {
            var user1 = _repo.GetUserById(id);
            if (user1 == null) return BadRequest("Usuário não encontrado");

             _repo.Update(user);
            if (_repo.SaveChanges())
            {
                return Ok(user);
            }
            return BadRequest("Usuário não cadastrado");
        }
        //api/user/id    
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, User user)
        {
            var user1 = _repo.GetUserById(id);
            if (user1 == null) return BadRequest("Usuário não encontrado");
            
             _repo.Update(user);
            if (_repo.SaveChanges())
            {
                return Ok(user);
            }
            return BadRequest("Usuário não cadastrado");
        }
        //api/user/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _repo.GetUserById(id);
            if (user == null) return BadRequest("Usuário não encontrado");

             _repo.Delete(user);
            if (_repo.SaveChanges())
            {
                return Ok("Usuário deleteado");
            }
            return BadRequest("Usuário não deletado");
        }


    }
}