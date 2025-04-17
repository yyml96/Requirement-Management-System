namespace _3.View
{
    partial class UserViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.UserList = new System.Windows.Forms.TabPage();
            this.Rolebutton = new System.Windows.Forms.Button();
            this.UserDeletebutton = new System.Windows.Forms.Button();
            this.UserEditbutton = new System.Windows.Forms.Button();
            this.UserAddbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.UserSearchtextBox = new System.Windows.Forms.TextBox();
            this.UsertabControl = new System.Windows.Forms.TabControl();
            this.UserDetail = new System.Windows.Forms.TabPage();
            this.userIdtextBox1 = new System.Windows.Forms.TextBox();
            this.Usercancelbutton = new System.Windows.Forms.Button();
            this.Usersavebutton = new System.Windows.Forms.Button();
            this.fullnametextBox = new System.Windows.Forms.TextBox();
            this.Fullname = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.passWordtextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.TabPage();
            this.roleCancelbutton = new System.Windows.Forms.Button();
            this.roleSavebutton = new System.Windows.Forms.Button();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.role_projectIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.role_userIDcomboBox = new System.Windows.Forms.ComboBox();
            this.roleIDtextBox = new System.Windows.Forms.TextBox();
            this.role_userID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.UserList.SuspendLayout();
            this.UsertabControl.SuspendLayout();
            this.UserDetail.SuspendLayout();
            this.UserRole.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Location = new System.Drawing.Point(30, 159);
            this.UserdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.RowHeadersWidth = 82;
            this.UserdataGridView.RowTemplate.Height = 24;
            this.UserdataGridView.Size = new System.Drawing.Size(1354, 686);
            this.UserdataGridView.TabIndex = 2;
            // 
            // UserList
            // 
            this.UserList.Controls.Add(this.Rolebutton);
            this.UserList.Controls.Add(this.UserDeletebutton);
            this.UserList.Controls.Add(this.UserEditbutton);
            this.UserList.Controls.Add(this.UserAddbutton);
            this.UserList.Controls.Add(this.UserdataGridView);
            this.UserList.Controls.Add(this.Searchbutton);
            this.UserList.Controls.Add(this.UserSearchtextBox);
            this.UserList.Location = new System.Drawing.Point(8, 50);
            this.UserList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserList.Name = "UserList";
            this.UserList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserList.Size = new System.Drawing.Size(1650, 905);
            this.UserList.TabIndex = 0;
            this.UserList.Text = "UserList";
            this.UserList.UseVisualStyleBackColor = true;
            // 
            // Rolebutton
            // 
            this.Rolebutton.Location = new System.Drawing.Point(1413, 472);
            this.Rolebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rolebutton.Name = "Rolebutton";
            this.Rolebutton.Size = new System.Drawing.Size(172, 69);
            this.Rolebutton.TabIndex = 6;
            this.Rolebutton.Text = "Role";
            this.Rolebutton.UseVisualStyleBackColor = true;
            // 
            // UserDeletebutton
            // 
            this.UserDeletebutton.Location = new System.Drawing.Point(1413, 365);
            this.UserDeletebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserDeletebutton.Name = "UserDeletebutton";
            this.UserDeletebutton.Size = new System.Drawing.Size(172, 69);
            this.UserDeletebutton.TabIndex = 5;
            this.UserDeletebutton.Text = "Delete";
            this.UserDeletebutton.UseVisualStyleBackColor = true;
            // 
            // UserEditbutton
            // 
            this.UserEditbutton.Location = new System.Drawing.Point(1413, 262);
            this.UserEditbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserEditbutton.Name = "UserEditbutton";
            this.UserEditbutton.Size = new System.Drawing.Size(172, 69);
            this.UserEditbutton.TabIndex = 4;
            this.UserEditbutton.Text = "Edit";
            this.UserEditbutton.UseVisualStyleBackColor = true;
            // 
            // UserAddbutton
            // 
            this.UserAddbutton.Location = new System.Drawing.Point(1413, 162);
            this.UserAddbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserAddbutton.Name = "UserAddbutton";
            this.UserAddbutton.Size = new System.Drawing.Size(172, 69);
            this.UserAddbutton.TabIndex = 3;
            this.UserAddbutton.Text = "Add new";
            this.UserAddbutton.UseVisualStyleBackColor = true;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(1413, 48);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(172, 69);
            this.Searchbutton.TabIndex = 1;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            // 
            // UserSearchtextBox
            // 
            this.UserSearchtextBox.Location = new System.Drawing.Point(30, 48);
            this.UserSearchtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserSearchtextBox.Name = "UserSearchtextBox";
            this.UserSearchtextBox.Size = new System.Drawing.Size(1354, 44);
            this.UserSearchtextBox.TabIndex = 0;
            // 
            // UsertabControl
            // 
            this.UsertabControl.Controls.Add(this.UserList);
            this.UsertabControl.Controls.Add(this.UserDetail);
            this.UsertabControl.Controls.Add(this.UserRole);
            this.UsertabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsertabControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertabControl.Location = new System.Drawing.Point(0, 133);
            this.UsertabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsertabControl.Name = "UsertabControl";
            this.UsertabControl.SelectedIndex = 0;
            this.UsertabControl.Size = new System.Drawing.Size(1666, 963);
            this.UsertabControl.TabIndex = 6;
            // 
            // UserDetail
            // 
            this.UserDetail.Controls.Add(this.userIdtextBox1);
            this.UserDetail.Controls.Add(this.Usercancelbutton);
            this.UserDetail.Controls.Add(this.Usersavebutton);
            this.UserDetail.Controls.Add(this.fullnametextBox);
            this.UserDetail.Controls.Add(this.Fullname);
            this.UserDetail.Controls.Add(this.emailtextBox);
            this.UserDetail.Controls.Add(this.Email);
            this.UserDetail.Controls.Add(this.passWordtextBox);
            this.UserDetail.Controls.Add(this.Password);
            this.UserDetail.Controls.Add(this.userNametextBox);
            this.UserDetail.Controls.Add(this.Username);
            this.UserDetail.Location = new System.Drawing.Point(8, 50);
            this.UserDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserDetail.Name = "UserDetail";
            this.UserDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserDetail.Size = new System.Drawing.Size(1650, 905);
            this.UserDetail.TabIndex = 1;
            this.UserDetail.Text = "User Detail";
            this.UserDetail.UseVisualStyleBackColor = true;
            // 
            // userIdtextBox1
            // 
            this.userIdtextBox1.Location = new System.Drawing.Point(124, 125);
            this.userIdtextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userIdtextBox1.Name = "userIdtextBox1";
            this.userIdtextBox1.Size = new System.Drawing.Size(182, 44);
            this.userIdtextBox1.TabIndex = 12;
            this.userIdtextBox1.Text = "0";
            // 
            // Usercancelbutton
            // 
            this.Usercancelbutton.Location = new System.Drawing.Point(519, 725);
            this.Usercancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usercancelbutton.Name = "Usercancelbutton";
            this.Usercancelbutton.Size = new System.Drawing.Size(322, 128);
            this.Usercancelbutton.TabIndex = 11;
            this.Usercancelbutton.Text = "Cancel";
            this.Usercancelbutton.UseVisualStyleBackColor = true;
            // 
            // Usersavebutton
            // 
            this.Usersavebutton.Location = new System.Drawing.Point(124, 725);
            this.Usersavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Usersavebutton.Name = "Usersavebutton";
            this.Usersavebutton.Size = new System.Drawing.Size(322, 128);
            this.Usersavebutton.TabIndex = 10;
            this.Usersavebutton.Text = "Save";
            this.Usersavebutton.UseVisualStyleBackColor = true;
            // 
            // fullnametextBox
            // 
            this.fullnametextBox.Location = new System.Drawing.Point(700, 578);
            this.fullnametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullnametextBox.Name = "fullnametextBox";
            this.fullnametextBox.Size = new System.Drawing.Size(439, 44);
            this.fullnametextBox.TabIndex = 9;
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Location = new System.Drawing.Point(704, 491);
            this.Fullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(146, 36);
            this.Fullname.TabIndex = 8;
            this.Fullname.Text = "Fullname";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(124, 578);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(439, 44);
            this.emailtextBox.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(128, 491);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(94, 36);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // passWordtextBox
            // 
            this.passWordtextBox.Location = new System.Drawing.Point(712, 381);
            this.passWordtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passWordtextBox.Name = "passWordtextBox";
            this.passWordtextBox.PasswordChar = '*';
            this.passWordtextBox.Size = new System.Drawing.Size(439, 44);
            this.passWordtextBox.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(716, 294);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(153, 36);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // userNametextBox
            // 
            this.userNametextBox.Location = new System.Drawing.Point(124, 381);
            this.userNametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(439, 44);
            this.userNametextBox.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(128, 294);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(161, 36);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // UserRole
            // 
            this.UserRole.Controls.Add(this.roleCancelbutton);
            this.UserRole.Controls.Add(this.roleSavebutton);
            this.UserRole.Controls.Add(this.rolecomboBox);
            this.UserRole.Controls.Add(this.label2);
            this.UserRole.Controls.Add(this.role_projectIDcomboBox);
            this.UserRole.Controls.Add(this.label1);
            this.UserRole.Controls.Add(this.role_userIDcomboBox);
            this.UserRole.Controls.Add(this.roleIDtextBox);
            this.UserRole.Controls.Add(this.role_userID);
            this.UserRole.Location = new System.Drawing.Point(8, 50);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(1650, 905);
            this.UserRole.TabIndex = 2;
            this.UserRole.Text = "User Role";
            this.UserRole.UseVisualStyleBackColor = true;
            // 
            // roleCancelbutton
            // 
            this.roleCancelbutton.Location = new System.Drawing.Point(478, 598);
            this.roleCancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleCancelbutton.Name = "roleCancelbutton";
            this.roleCancelbutton.Size = new System.Drawing.Size(322, 128);
            this.roleCancelbutton.TabIndex = 13;
            this.roleCancelbutton.Text = "Cancel";
            this.roleCancelbutton.UseVisualStyleBackColor = true;
            // 
            // roleSavebutton
            // 
            this.roleSavebutton.Location = new System.Drawing.Point(83, 598);
            this.roleSavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleSavebutton.Name = "roleSavebutton";
            this.roleSavebutton.Size = new System.Drawing.Size(322, 128);
            this.roleSavebutton.TabIndex = 12;
            this.roleSavebutton.Text = "Save";
            this.roleSavebutton.UseVisualStyleBackColor = true;
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Items.AddRange(new object[] {
            "Project Manager",
            "Project Member"});
            this.rolecomboBox.Location = new System.Drawing.Point(83, 452);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(360, 44);
            this.rolecomboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Role";
            // 
            // role_projectIDcomboBox
            // 
            this.role_projectIDcomboBox.FormattingEnabled = true;
            this.role_projectIDcomboBox.Location = new System.Drawing.Point(557, 245);
            this.role_projectIDcomboBox.Name = "role_projectIDcomboBox";
            this.role_projectIDcomboBox.Size = new System.Drawing.Size(360, 44);
            this.role_projectIDcomboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Project";
            // 
            // role_userIDcomboBox
            // 
            this.role_userIDcomboBox.FormattingEnabled = true;
            this.role_userIDcomboBox.Location = new System.Drawing.Point(83, 245);
            this.role_userIDcomboBox.Name = "role_userIDcomboBox";
            this.role_userIDcomboBox.Size = new System.Drawing.Size(360, 44);
            this.role_userIDcomboBox.TabIndex = 7;
            // 
            // roleIDtextBox
            // 
            this.roleIDtextBox.Location = new System.Drawing.Point(73, 81);
            this.roleIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleIDtextBox.Name = "roleIDtextBox";
            this.roleIDtextBox.Size = new System.Drawing.Size(102, 44);
            this.roleIDtextBox.TabIndex = 6;
            this.roleIDtextBox.Text = "0";
            // 
            // role_userID
            // 
            this.role_userID.AutoSize = true;
            this.role_userID.Location = new System.Drawing.Point(77, 179);
            this.role_userID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.role_userID.Name = "role_userID";
            this.role_userID.Size = new System.Drawing.Size(178, 36);
            this.role_userID.TabIndex = 4;
            this.role_userID.Text = "Select User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.User);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1666, 133);
            this.panel1.TabIndex = 5;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(32, 34);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(97, 42);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // UserViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1096);
            this.Controls.Add(this.UsertabControl);
            this.Controls.Add(this.panel1);
            this.Name = "UserViewForm";
            this.Text = "UserViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.UserList.ResumeLayout(false);
            this.UserList.PerformLayout();
            this.UsertabControl.ResumeLayout(false);
            this.UserDetail.ResumeLayout(false);
            this.UserDetail.PerformLayout();
            this.UserRole.ResumeLayout(false);
            this.UserRole.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.TabPage UserList;
        private System.Windows.Forms.Button UserDeletebutton;
        private System.Windows.Forms.Button UserEditbutton;
        private System.Windows.Forms.Button UserAddbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox UserSearchtextBox;
        private System.Windows.Forms.TabControl UsertabControl;
        private System.Windows.Forms.TabPage UserDetail;
        private System.Windows.Forms.Button Usercancelbutton;
        private System.Windows.Forms.Button Usersavebutton;
        private System.Windows.Forms.TextBox fullnametextBox;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox passWordtextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox userIdtextBox1;
        private System.Windows.Forms.TabPage UserRole;
        private System.Windows.Forms.ComboBox role_projectIDcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox role_userIDcomboBox;
        private System.Windows.Forms.TextBox roleIDtextBox;
        private System.Windows.Forms.Label role_userID;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button roleCancelbutton;
        private System.Windows.Forms.Button roleSavebutton;
        private System.Windows.Forms.Button Rolebutton;
    }
}