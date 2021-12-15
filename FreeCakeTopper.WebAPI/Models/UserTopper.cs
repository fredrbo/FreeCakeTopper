namespace FreeCakeTopper.WebAPI.Models
{
    public class UserTopper
    {
        public UserTopper(){}
        public UserTopper(int userId, int topperId){
            this.UserId = userId;
            this.TopperId = topperId;
        }

        public int UserId { get; set; }
        public int TopperId { get; set; }
    }
}