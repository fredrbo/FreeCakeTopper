using System.Collections.Generic;

namespace FreeCakeTopper.WebAPI.Models
{
    public class TopperName
    {
        public TopperName() { }

        public TopperName(int id, string name, string font, string color,int userId)
        {
            this.Id = id;
            this.Name = name;
            this.Font = font;
            this.Color = color;
            this.UserId = userId;


        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Font { get; set; }
        public string Color { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public  IEnumerable<UserTopper> UserToppers { get; set; }
    }
}