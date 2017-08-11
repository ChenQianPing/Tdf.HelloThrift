using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloThrift.Interface;

namespace HelloThrift.Server
{
    public class MyUserService : UserService.Iface
    {

        private readonly List<User> _users = new List<User>();
        private int _nextId = 1;

        public MyUserService()
        {
            Add(new User { UserName = "Tomato soup", UserPass = "Groceries", Email = "Groceries@gmail.com", RegTime = "2017-08-11"});
            Add(new User { UserName = "Yo-yo", UserPass = "Toys", Email = "Toys@gmail..com", RegTime = "2017-08-11" });
            Add(new User { UserName = "Hammer", UserPass = "Hardware", Email = "Hardware@gmail.com", RegTime = "2017-08-11" });
        }

        public bool Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException($"user");
            }

            user.Id = _nextId++;
            _users.Add(user);

            return true;
        }

        public bool Delete(int id)
        {
            _users.RemoveAll(p => p.Id == id);

            return true;
        }

        public List<User> GetAllUser()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.Find(p => p.Id == id);
        }

        public List<User> GetUserByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int GetUserCount()
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException($"user");
            }

            var index = _users.FindIndex(p => p.Id == user.Id);
            if (index == -1)
            {
                return false;
            }

            _users.RemoveAt(index);
            _users.Add(user);
            return true;
        }
    }
}
