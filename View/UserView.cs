using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.View
{
    public interface UserView
    {

        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string Fullname { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }

        string Message { get; set; }
        string Id { get; set; }

        string RoleID { get; set; }
        string ProjectID { get; set; }
        string RoleName { get; set; }

        string UserID { get; set; }



        //Event Handlers
        event EventHandler SearchUserEvent;
        event EventHandler AddUserEvent;
        event EventHandler EditUserEvent;
        event EventHandler DeleteUserEvent;   
        event EventHandler SaveUserEvent;
        event EventHandler CancelUserEvent;
        event EventHandler RoleUserEvent;
        event EventHandler SaveRoleUserEvent;
        event EventHandler CancelRoleUserEvent;

        //Methods
        void SetUserListBindingSource(BindingSource userList);

        void SetProjectComboBoxBindingSource(BindingSource role_project);

       
        
        void show();
        void ShowDialog();
    }

    

    
}
