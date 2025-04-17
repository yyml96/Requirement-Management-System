using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.Model;
using _3.View;

namespace _3.Presenter
{
    public class UserPresenter
    {
        private UserView view;
        
        private IUserRepo repo;
        private BindingSource userBindingSource;
        private BindingSource role_projectBindingSource;
        private IEnumerable<User> userList;
        private IEnumerable<Project> role_project;
        

        public UserPresenter(UserView view, IUserRepo repo)
        {
            this.userBindingSource = new BindingSource();
            this.role_projectBindingSource = new BindingSource();
            
            this.view = view;
            
            this.repo = repo;

            this.view.SearchUserEvent += SearchUserEvent;
            this.view.AddUserEvent += AddUserEvent;
            this.view.EditUserEvent += EditUserEvent;
            this.view.DeleteUserEvent += DeleteUserEvent;
            this.view.SaveUserEvent += SaveUserEvent;
            this.view.CancelUserEvent += CancelUserEvent;
            this.view.SaveRoleUserEvent += SaveRoleUserEvent;
            this.view.CancelRoleUserEvent += CancelRoleUserEvent;

            this.view.SetUserListBindingSource(userBindingSource);
            this.view.SetProjectComboBoxBindingSource(role_projectBindingSource);

            LoadProject();
            LoadAllUserList();
            this.view.show();
            
        }

        

        private void SearchUserEvent(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                userList = repo.GetUserByValue(this.view.SearchValue);

            else userList = repo.GetAllUsers();
            userBindingSource.DataSource = userList;
        }

        private void AddUserEvent(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void EditUserEvent(object sender, EventArgs e)
        {

            var user = (User)userBindingSource.Current;
            view.Id = user.Id.ToString();
            view.Username = user.Username;
            view.Password = user.Password;
            view.Email = user.Email;
            view.Fullname = user.Fullname;
            view.IsEdit = true;
        }

        private void DeleteUserEvent(object sender, EventArgs e)
        {
            try
            {
                var user = (User)userBindingSource.Current;
                repo.DeleteUser(user.Id);
                view.IsSuccessful = true;
                view.Message = "User deleted successfully";
                LoadAllUserList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured";
            }
        }

        private void SaveUserEvent(object sender, EventArgs e)
        {
            var model = new User();
            model.Id = Convert.ToInt32(view.Id);
            model.Username = view.Username;
            model.Password = view.Password;
            model.Email = view.Email;
            model.Fullname = view.Fullname;
            try
            {
                new ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repo.EditUser(model);
                    view.Message = " User updated successfully";
                }
                else
                {
                    repo.AddUser(model);
                    view.Message = " User added successfully";
                }
                view.IsSuccessful = true;
                LoadAllUserList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.Id = "0";
            view.Username = "";
            view.Password = "";
            view.Email = "";
            view.Fullname = "";
        }

        private void CancelUserEvent(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void LoadAllUserList()
        {
            userList = repo.GetAllUsers();
            userBindingSource.DataSource = userList;
        }

        //Role
        private void SaveRoleUserEvent(object sender, EventArgs e)
        {
            var role = new UserRole();
            role.Project_id = Convert.ToInt32(view.ProjectID);
            role.Role_id = Convert.ToInt32(view.RoleID);
            role.Role_name = view.RoleName;
            role.User_id = Convert.ToInt32(view.UserID);

            repo.AddRole(role);
            view.IsSuccessful = true;
            view.Message = " UserRole added successfully";



        }

        private void RoleCleanViewFields()
        {
            view.RoleID = "0";
            view.RoleName = "";
            view.ProjectID = "";
            view.UserID = "";
        }

        private void CancelRoleUserEvent(object sender, EventArgs e)
        {
            RoleCleanViewFields();
        }

        private void LoadProject()
        {
            role_project = repo.GetProjects();
            role_projectBindingSource.DataSource = role_project;
        }
    }
}
