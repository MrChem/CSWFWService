using CSWFWInterface;
using CSWFWModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSWFWUserServiice
{
    public class UserService : IUserseSvice
    {
        private List<User> _users = new List<User>();
        public UserService() {
            _users.Add(new User()
            {
                id = "1",
                name = "客户1",
                tag="客户1"
            }) ;
            _users.Add(new User()
            {
                id = "2",
                name = "客户2",
                tag = "客户1"
            });

        }
        public List<User> getAllUser()
        {
            return _users;
        }

        public User getUser(string name)
        {
            Console.WriteLine($"调用时间{DateTime.Now.ToLongDateString()}");
            return _users.Find(x => x.name.Contains(name));
        }
    }
}
