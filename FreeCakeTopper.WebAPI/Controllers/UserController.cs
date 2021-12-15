using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FreeCakeTopper.WebAPI.Models;
using System.Linq;

namespace FreeCakeTopper.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
     public List<User> Users = new List<User>(){
         new User() {
             Id = 1,
             Name = "Jose",
             Email = "Jose@gmail.com",
             Password = "123"
          },
         new User() {
             Id = 2,
             Name = "Neusa",
             Email = "Neusa@gmail.com",
             Password = "542"
          },
         new User() {
             Id = 3,
             Name = "Fred",
             Email = "Fred@gmail.com",
             Password = "@Aim"
          },
     };
     public UserController() {}

    //api/user
    [HttpGet]
     public IActionResult Get(){
         return Ok(Users);
     }   
     //api/user/byId?id=1 
    [HttpGet("byId")]
     public IActionResult GetById(int id){

         var user = Users.FirstOrDefault(u => u.Id == id);
         if (user == null) return BadRequest("Usuario não encontrado");
         return Ok(user);
     }    

    [HttpGet("ByName")]
    public IActionResult GetByName (string name, string email)
    {
        var user = Users.FirstOrDefault(u => 
        u.Name.Contains(name) && u.Email.Contains(email));
        if (user == null) return BadRequest("Usuario ou email não encontrado");

        return Ok(user); 
    }
    //api/user
    [HttpPost()]
    public IActionResult Post (User user)
    {
        return Ok(user); 
    }

    //api/user/id
    [HttpPut("{id}")]
    public IActionResult Put (int id, User user)
    {
        return Ok(user); 
    }
    //api/user/id    
    [HttpPatch("{id}")]
    public IActionResult Patch (int id, User user)
    {
        return Ok(user); 
    }
    //api/user/id
    [HttpDelete("{id}")]
    public IActionResult Delete (int id, User user)
    {
        return Ok(user); 
    }


    }
}