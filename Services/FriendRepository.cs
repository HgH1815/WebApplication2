using WebApplication2.Data; // یا هرفولدری که DbContext توش هست
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class FriendsRepository
    {
        private readonly ApplicationDbContext _db;

        public FriendsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        // Read All
        public List<Friend> GetAll()
        {
            return _db.Friends.ToList();
        }

        // Read Single
        public Friend? GetByNumber(int number)
        {
            return _db.Friends.FirstOrDefault(f => f.Number == number);
        }

        // Create
        public void Add(Friend friend)
        {
            _db.Friends.Add(friend);
            _db.SaveChanges();
        }

        // Update
        public void Update(Friend friend)
        {
            _db.Friends.Update(friend);
            _db.SaveChanges();
        }

        // Delete
        public void Delete(int number)
        {
            var friend = GetByNumber(number);
            if (friend != null)
            {
                _db.Friends.Remove(friend);
                _db.SaveChanges();
            }
        }
    }
}