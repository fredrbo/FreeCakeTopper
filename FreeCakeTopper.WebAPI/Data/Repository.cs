using System.Linq;
using FreeCakeTopper.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeCakeTopper.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public bool SaveChanges()
        {
            // retorna true se foi salvo
            return (_context.SaveChanges() > 0);
        }

        //TOPPERS
        public TopperName[] GetAllToppers()
        {
            IQueryable<TopperName> query = _context.TopperNames;

            query = query.AsNoTracking().OrderBy(t => t.Id);
            return query.ToArray();
        }

        public TopperName[] GetAllToppersByUserId(int userId)
        {
            IQueryable<TopperName> query = _context.TopperNames;

            query = query.AsNoTracking()
                         .OrderBy(t => t.Id)
                         .Where(u => u.UserId == userId);

            return query.ToArray();
        }

        //USERS
        public User[] GetAllUsers()
        {
            IQueryable<User> query = _context.Users;

            query = query.AsNoTracking()
                                 .OrderBy(t => t.Id);

            return query.ToArray();

        }
        public User[] GetUserById(int Id)
        {
            IQueryable<User> query = _context.Users;

            query = query.AsNoTracking()
                         .OrderBy(t => t.Id)
                         .Where(u => u.Id == Id);

            return query.ToArray();
        }

    }
}