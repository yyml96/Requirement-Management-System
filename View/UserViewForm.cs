using _3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.View
{
    public partial class UserViewForm : Form, UserView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public UserViewForm()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
            UsertabControl.TabPages.Remove(UserDetail);
            UsertabControl.TabPages.Remove(UserRole);
            
            userIdtextBox1.Enabled = true;
            userIdtextBox1.Visible = false;

            roleIDtextBox.Enabled = false;
            roleIDtextBox.Visible = true;
        }

        private void AssociateAndRaiseEvent()
        {
            Searchbutton.Click += delegate { SearchUserEvent?.Invoke(this, EventArgs.Empty); };
            UserSearchtextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchUserEvent?.Invoke(this, EventArgs.Empty);
            };

            UserAddbutton.Click += delegate
            {
                AddUserEvent?.Invoke(this, EventArgs.Empty);
                UsertabControl.TabPages.Remove(UserList);
                UsertabControl.TabPages.Add(UserDetail);
                UserDetail.Text = "Add New User";
            };

            UserEditbutton.Click += delegate
            {
                EditUserEvent?.Invoke(this, EventArgs.Empty);
                UsertabControl.TabPages.Remove(UserList);
                UsertabControl.TabPages.Add(UserDetail);
                UserDetail.Text = "Edit User";
            };

            UserDeletebutton.Click += delegate
            {
                
                var result = MessageBox.Show("Are you sure you want to delete the selected user?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteUserEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);
                }
            };

            Usersavebutton.Click += delegate
            {
                SaveUserEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    UsertabControl.TabPages.Remove(UserDetail);
                    UsertabControl.TabPages.Add(UserList);
                }
                MessageBox.Show(message);
            };

            Usercancelbutton.Click += delegate
            {
                CancelUserEvent?.Invoke(this, EventArgs.Empty);
                UsertabControl.TabPages.Remove(UserDetail);
                UsertabControl.TabPages.Add(UserList);
            };

            Rolebutton.Click += delegate
            {
                RoleUserEvent?.Invoke(this, EventArgs.Empty);
                UsertabControl.TabPages.Remove(UserList);
                UsertabControl.TabPages.Add(UserRole);
                UserRole.Text = "Add Role";
            };

            roleSavebutton.Click += delegate
            {
                SaveRoleUserEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    UsertabControl.TabPages.Remove(UserRole);
                    UsertabControl.TabPages.Add(UserList);
                }
                MessageBox.Show(message);
            };

            roleCancelbutton.Click += delegate
            {
                CancelRoleUserEvent?.Invoke(this, EventArgs.Empty);
                UsertabControl.TabPages.Remove(UserRole);
                UsertabControl.TabPages.Add(UserList);
            };

        }

        public string SearchValue
        {
            get { return UserSearchtextBox.Text; }
            set { UserSearchtextBox.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        
        string UserView.Username
        {
            get { return userNametextBox.Text; }
            set { userNametextBox.Text = value; }
        }

        string UserView.Password
        {
            get { return passWordtextBox.Text; }
            set { passWordtextBox.Text = value; }
        }

        string UserView.Email
        {
            get { return emailtextBox.Text; }
            set { emailtextBox.Text = value; }
        }

        string UserView.Fullname
        {
            get { return fullnametextBox.Text; }
            set { fullnametextBox.Text = value; }
        }
       

        string UserView.Id
        { 
            get { return userIdtextBox1.Text; }
            set { userIdtextBox1.Text = value; }
        }

       //role
       string UserView.RoleID
        {
            get { return roleIDtextBox.Text; }
            set { roleIDtextBox.Text = value; }
        }

        string UserView.ProjectID
        {
            get { return role_projectIDcomboBox.SelectedValue.ToString(); }
            set { role_projectIDcomboBox.SelectedValue = value; }
        }

        string UserView.RoleName
        {
            get { return rolecomboBox.SelectedItem.ToString(); }
            set { rolecomboBox.SelectedItem = value; }
        }

        string UserView.UserID
        {
            get { return role_userIDcomboBox.SelectedValue.ToString(); }
            set { role_userIDcomboBox.SelectedValue = value; }
        }

        // Event Handlers
        public event EventHandler SearchUserEvent;
        public event EventHandler AddUserEvent;
        public event EventHandler EditUserEvent;
        public event EventHandler DeleteUserEvent;
        public event EventHandler SaveUserEvent;
        public event EventHandler CancelUserEvent;
        public event EventHandler RoleUserEvent;
        public event EventHandler SaveRoleUserEvent;
        public event EventHandler CancelRoleUserEvent;

        //Methods

        public void SetUserListBindingSource(BindingSource userList)
        {
            UserdataGridView.DataSource = userList;
            UserdataGridView.ColumnAdded += DataGridView_ColumnAdded;
            role_userIDcomboBox.DataSource = userList;
            role_userIDcomboBox.DisplayMember = "Username";
            role_userIDcomboBox.ValueMember = "Id";
        }

        //role
        public void SetProjectComboBoxBindingSource(BindingSource role_project)
        {
            role_projectIDcomboBox.DataSource = role_project;
            role_projectIDcomboBox.DisplayMember = "Project_name";
            role_projectIDcomboBox.ValueMember = "Project_id";
        }

        public void DataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "Password" || e.Column.Name == "Phone")
            {
                e.Column.Visible = false;

            }
        }

        public void show()
        {
            this.ShowDialog();

        }

        void UserView.ShowDialog()
        {
            this.Hide();
        }
    }
}
