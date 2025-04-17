using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Model
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private string fullname;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = 
            "Username can not be less than 2 and more than 50 characters")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = 
                       "Password can not be less than 2 and more than 50 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = 
                                  "Email can not be more than 50 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Fullname")]
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
    }

    public class UserRole
    { 
        private int role_id;
        private string role_name;
        private int user_id;
        private int project_id;

        public int Role_id
        {
            get { return role_id; }
            set { role_id = value; }
        }

        public string Role_name
        {
            get { return role_name; }
            set { role_name = value; }
        }

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public int Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }
    }
}
