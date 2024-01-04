using Project.Models;

namespace Project.Новая_папка
{
    public class UserService
    {
        List<User> Usersers = new List<User>()
             {
           new User(){name="Mahmud",role="Oshpaz", phone =923848293},
         new User(){name="Bilol",role="Waiter", phone =929384954},
         new User(){name="Behzod", role="Manager", phone =87654323},
        };

        public void AddUser(User user)
        {
            
            Usersers.Add(user);
        }
        public List<User> GetUsers()
        {
            return Usersers;
        }


    }
}
