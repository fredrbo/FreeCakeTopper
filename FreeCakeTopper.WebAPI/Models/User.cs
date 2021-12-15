using System.Collections.Generic;

namespace FreeCakeTopper.WebAPI.Models
{
    public class User
    {
        public User(){}

        public User(int Id, string Name, string Email, string Password){
            this.Id = Id;
            this.Name = Name;
            this.Email= Email;
            this.Password = Password;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  IEnumerable<TopperName> TopperNames { get; set; }
    }
}