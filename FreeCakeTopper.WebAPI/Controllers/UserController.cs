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
    private readonly DataContext _context;
     public UserController(DataContext context) {
         _context = context;
     }
    
    //api/user
    [HttpGet]
     public IActionResult Get(){
         return Ok(_context.Users);
     }   
     //api/user/byId?id=1 
    [HttpGet("byId")]
     public IActionResult GetById(int id){

         var user = _context.Users.FirstOrDefault(u => u.Id == id);
         if (user == null) return BadRequest("Usuario não encontrado");
         return Ok(user);
     }    

    [HttpGet("ByName")]
    public IActionResult GetByName (string name, string email)
    {
        var user = _context.Users.FirstOrDefault(u => 
        u.Name.Contains(name) && u.Email.Contains(email));
        if (user == null) return BadRequest("Usuario ou email não encontrado");

        return Ok(user); 
    }
    //api/user
    [HttpPost()]
    public IActionResult Post (User user)
    {
        _context.Add(user);
        _context.SaveChanges();
        return Ok(user); 
    }

    //api/user/id
    [HttpPut("{id}")]
    public IActionResult Put (int id, User user)
    {
        var user1 = _context.Users.AsNoTracking().FirstOrDefault(u => u.Id == id);
        if (user1 == null) return BadRequest("Usuário não encontrado");

        _context.Update(user);
        _context.SaveChanges();
        return Ok(user); 
    }
    //api/user/id    
    [HttpPatch("{id}")]
    public IActionResult Patch (int id, User user)
    {
        var user1 = _context.Users.AsNoTracking().FirstOrDefault(u => u.Id == id);
        if (user1 == null) return BadRequest("Usuário não encontrado");
        _context.Update(user);
        _context.SaveChanges();
        return Ok(user); 
    }
    //api/user/id
    [HttpDelete("{id}")]
    public IActionResult Delete (int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == id);
        if (user == null) return BadRequest("Usuário não encontrado");
        
        _context.Remove(user);
        _context.SaveChanges();
        return Ok(user); 
    }


    }
}