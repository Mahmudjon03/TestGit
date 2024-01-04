using Project.Models;

namespace Project.Новая_папка
{
    public class UserService
    {
        List<User> Usersers = new List<User>()
             {
            new User(){name="ali",email="asdfghjm", phone ="sdfghj"},
              new User(){name="ali",email="asdfghjm", phone ="sdfghj"},
                new User(){name="ali",email="asdfghjm", phone ="sdfghj"},
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
