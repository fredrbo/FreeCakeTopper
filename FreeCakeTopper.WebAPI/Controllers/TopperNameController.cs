using System.Collections.Generic;
using System.Linq;
using FreeCakeTopper.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace FreeCakeTopper.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopperNameController : ControllerBase
    {
        public TopperNameController() {}
        public List<TopperName> Toppers = new List<TopperName>(){
         new TopperName() {
             Id = 1,
             Name = "Ana",
             Font = "Arial",
             Color = "Black",
             UserId = 1
          },
         new TopperName() {
             Id = 2,
             Name = "Heitor",
             Font = "Helvetica",
             Color = "Red",
             UserId = 1
          },
         new TopperName() {
             Id = 3,
             Name = "Jonas",
             Font = "Bonita",
             Color = "Blue",
             UserId = 2
          },
         new TopperName() {
             Id = 4,
             Name = "Ranger",
             Font = "Arial",
             Color = "Orange",
             UserId = 2
          },
     };

        [HttpGet]
        public IActionResult Get(){
            return Ok("Topper, josé, arial, blue");
        }

    //api/user/byuserId?id=1 
    [HttpGet("byUserId")]
     public IActionResult GetByUserId(int userId){
         // retornando apenas o primeiro
         var user = Toppers.FirstOrDefault(u => u.UserId == userId);
         if (user == null) return BadRequest("Usuario não encontrado");
         return Ok(user);
     }   
    }
}