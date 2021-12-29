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

        private readonly IRepository _repo;

        public TopperNameController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetToppers()
        {
            var result = _repo.GetAllToppers();
            return Ok(result);

        }

        //api/user/byuserId?id=1 
        [HttpGet("byUserId")]
        public IActionResult GetByUserId(int userId)
        {
            // retornando apenas o primeiro
            var user = _repo.GetAllToppersByUserId(userId);
            if (user == null) return BadRequest("Usuario não encontrado");
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post(TopperName topperName)
        {
            _repo.Add(topperName);
            if (_repo.SaveChanges())
            {
                return Ok(topperName);
            }
            return BadRequest("Topo não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TopperName topperName)
        {

            var topper = _repo.GetAllToppersByUserId(id);
            if (topper == null) return BadRequest("Nome não encontrado");

            _repo.Update(topperName);
            if (_repo.SaveChanges())
            {
                return Ok(topperName);
            }
            return BadRequest("Topo não cadastrado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, TopperName topperName)
        {
            var topper = _repo.GetAllToppersByUserId(id);
            if (topper == null) return BadRequest("Nome não encontrado");

            _repo.Update(topperName);
            if (_repo.SaveChanges())
            {
                return Ok(topperName);
            }
            return BadRequest("Topo não cadastrado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var topper = _repo.GetAllToppersByUserId(id);
            if (topper == null) return BadRequest("Nome não encontrado");

            _repo.Delete(topper);
            if (_repo.SaveChanges())
            {
                return Ok(topper);
            }
            return BadRequest("Topo não cadastrado");

        }
    }
}