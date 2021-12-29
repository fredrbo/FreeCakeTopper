using FreeCakeTopper.WebAPI.Models;

namespace FreeCakeTopper.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        bool SaveChanges();

        //TOPPER
        TopperName[] GetAllToppers();
        TopperName[] GetAllToppersByUserId(int userId);
        
        //USERS
        User[] GetAllUsers();
        User[] GetUserById(int Id);

    }
}