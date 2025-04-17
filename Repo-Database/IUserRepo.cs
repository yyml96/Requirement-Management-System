using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Model
{
    public interface IUserRepo
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int id);
        
        IEnumerable<User> GetUserByValue(string value);
        IEnumerable<User> GetAllUsers();

       IEnumerable<Project> GetProjects();

        void AddRole (UserRole role);
    }
}
