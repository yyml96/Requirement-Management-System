namespace _3.View
{
    partial class ProjectViewForm
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
            this.ProjecttabControl = new System.Windows.Forms.TabControl();
            this.ProjectList = new System.Windows.Forms.TabPage();
            this.projectDeletebutton = new System.Windows.Forms.Button();
            this.projectEditbutton = new System.Windows.Forms.Button();
            this.projectAddbutton = new System.Windows.Forms.Button();
            this.projectdataGridView = new System.Windows.Forms.DataGridView();
            this.projectSearchbutton = new System.Windows.Forms.Button();
            this.projectSearchtextBox = new System.Windows.Forms.TextBox();
            this.ProjectDetail = new System.Windows.Forms.TabPage();
            this.projectdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.projectIdtextBox1 = new System.Windows.Forms.TextBox();
            this.Projectcancelbutton = new System.Windows.Forms.Button();
            this.Projectsavebutton = new System.Windows.Forms.Button();
            this.Created = new System.Windows.Forms.Label();
            this.projectdesctextBox = new System.Windows.Forms.TextBox();
            this.projectDesc = new System.Windows.Forms.Label();
            this.projectNametextBox = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Project = new System.Windows.Forms.Label();
            this.ProjecttabControl.SuspendLayout();
            this.ProjectList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectdataGridView)).BeginInit();
            this.ProjectDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjecttabControl
            // 
            this.ProjecttabControl.Controls.Add(this.ProjectList);
            this.ProjecttabControl.Controls.Add(this.ProjectDetail);
            this.ProjecttabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjecttabControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjecttabControl.Location = new System.Drawing.Point(0, 133);
            this.ProjecttabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjecttabControl.Name = "ProjecttabControl";
            this.ProjecttabControl.SelectedIndex = 0;
            this.ProjecttabControl.Size = new System.Drawing.Size(1683, 1001);
            this.ProjecttabControl.TabIndex = 8;
            // 
            // ProjectList
            // 
            this.ProjectList.Controls.Add(this.projectDeletebutton);
            this.ProjectList.Controls.Add(this.projectEditbutton);
            this.ProjectList.Controls.Add(this.projectAddbutton);
            this.ProjectList.Controls.Add(this.projectdataGridView);
            this.ProjectList.Controls.Add(this.projectSearchbutton);
            this.ProjectList.Controls.Add(this.projectSearchtextBox);
            this.ProjectList.Location = new System.Drawing.Point(8, 50);
            this.ProjectList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectList.Size = new System.Drawing.Size(1667, 943);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.Text = "Project List";
            this.ProjectList.UseVisualStyleBackColor = true;
            // 
            // projectDeletebutton
            // 
            this.projectDeletebutton.Location = new System.Drawing.Point(1413, 365);
            this.projectDeletebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDeletebutton.Name = "projectDeletebutton";
            this.projectDeletebutton.Size = new System.Drawing.Size(172, 69);
            this.projectDeletebutton.TabIndex = 5;
            this.projectDeletebutton.Text = "Delete";
            this.projectDeletebutton.UseVisualStyleBackColor = true;
            // 
            // projectEditbutton
            // 
            this.projectEditbutton.Location = new System.Drawing.Point(1413, 262);
            this.projectEditbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectEditbutton.Name = "projectEditbutton";
            this.projectEditbutton.Size = new System.Drawing.Size(172, 69);
            this.projectEditbutton.TabIndex = 4;
            this.projectEditbutton.Text = "Edit";
            this.projectEditbutton.UseVisualStyleBackColor = true;
            // 
            // projectAddbutton
            // 
            this.projectAddbutton.Location = new System.Drawing.Point(1413, 162);
            this.projectAddbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectAddbutton.Name = "projectAddbutton";
            this.projectAddbutton.Size = new System.Drawing.Size(172, 69);
            this.projectAddbutton.TabIndex = 3;
            this.projectAddbutton.Text = "Add new";
            this.projectAddbutton.UseVisualStyleBackColor = true;
            // 
            // projectdataGridView
            // 
            this.projectdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectdataGridView.Location = new System.Drawing.Point(30, 159);
            this.projectdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectdataGridView.Name = "projectdataGridView";
            this.projectdataGridView.RowHeadersWidth = 82;
            this.projectdataGridView.RowTemplate.Height = 24;
            this.projectdataGridView.Size = new System.Drawing.Size(1354, 686);
            this.projectdataGridView.TabIndex = 2;
            // 
            // projectSearchbutton
            // 
            this.projectSearchbutton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectSearchbutton.Location = new System.Drawing.Point(1413, 48);
            this.projectSearchbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectSearchbutton.Name = "projectSearchbutton";
            this.projectSearchbutton.Size = new System.Drawing.Size(172, 69);
            this.projectSearchbutton.TabIndex = 1;
            this.projectSearchbutton.Text = "Search";
            this.projectSearchbutton.UseVisualStyleBackColor = true;
            // 
            // projectSearchtextBox
            // 
            this.projectSearchtextBox.Location = new System.Drawing.Point(30, 48);
            this.projectSearchtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectSearchtextBox.Name = "projectSearchtextBox";
            this.projectSearchtextBox.Size = new System.Drawing.Size(1354, 44);
            this.projectSearchtextBox.TabIndex = 0;
            // 
            // ProjectDetail
            // 
            this.ProjectDetail.Controls.Add(this.projectdateTimePicker1);
            this.ProjectDetail.Controls.Add(this.projectIdtextBox1);
            this.ProjectDetail.Controls.Add(this.Projectcancelbutton);
            this.ProjectDetail.Controls.Add(this.Projectsavebutton);
            this.ProjectDetail.Controls.Add(this.Created);
            this.ProjectDetail.Controls.Add(this.projectdesctextBox);
            this.ProjectDetail.Controls.Add(this.projectDesc);
            this.ProjectDetail.Controls.Add(this.projectNametextBox);
            this.ProjectDetail.Controls.Add(this.ProjectName);
            this.ProjectDetail.Location = new System.Drawing.Point(8, 50);
            this.ProjectDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectDetail.Name = "ProjectDetail";
            this.ProjectDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectDetail.Size = new System.Drawing.Size(1667, 943);
            this.ProjectDetail.TabIndex = 1;
            this.ProjectDetail.Text = "Project Detail";
            this.ProjectDetail.UseVisualStyleBackColor = true;
            // 
            // projectdateTimePicker1
            // 
            this.projectdateTimePicker1.Location = new System.Drawing.Point(689, 323);
            this.projectdateTimePicker1.Name = "projectdateTimePicker1";
            this.projectdateTimePicker1.Size = new System.Drawing.Size(529, 44);
            this.projectdateTimePicker1.TabIndex = 13;
            // 
            // projectIdtextBox1
            // 
            this.projectIdtextBox1.Location = new System.Drawing.Point(124, 125);
            this.projectIdtextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectIdtextBox1.Name = "projectIdtextBox1";
            this.projectIdtextBox1.Size = new System.Drawing.Size(182, 44);
            this.projectIdtextBox1.TabIndex = 12;
            this.projectIdtextBox1.Text = "0";
            // 
            // Projectcancelbutton
            // 
            this.Projectcancelbutton.Location = new System.Drawing.Point(519, 725);
            this.Projectcancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Projectcancelbutton.Name = "Projectcancelbutton";
            this.Projectcancelbutton.Size = new System.Drawing.Size(322, 128);
            this.Projectcancelbutton.TabIndex = 11;
            this.Projectcancelbutton.Text = "Cancel";
            this.Projectcancelbutton.UseVisualStyleBackColor = true;
            // 
            // Projectsavebutton
            // 
            this.Projectsavebutton.Location = new System.Drawing.Point(124, 725);
            this.Projectsavebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Projectsavebutton.Name = "Projectsavebutton";
            this.Projectsavebutton.Size = new System.Drawing.Size(322, 128);
            this.Projectsavebutton.TabIndex = 10;
            this.Projectsavebutton.Text = "Save";
            this.Projectsavebutton.UseVisualStyleBackColor = true;
            // 
            // Created
            // 
            this.Created.AutoSize = true;
            this.Created.Location = new System.Drawing.Point(683, 239);
            this.Created.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(308, 36);
            this.Created.TabIndex = 8;
            this.Created.Text = "Project Created Date";
            // 
            // projectdesctextBox
            // 
            this.projectdesctextBox.Location = new System.Drawing.Point(124, 528);
            this.projectdesctextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectdesctextBox.Name = "projectdesctextBox";
            this.projectdesctextBox.Size = new System.Drawing.Size(439, 44);
            this.projectdesctextBox.TabIndex = 7;
            // 
            // projectDesc
            // 
            this.projectDesc.AutoSize = true;
            this.projectDesc.Location = new System.Drawing.Point(128, 430);
            this.projectDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectDesc.Name = "projectDesc";
            this.projectDesc.Size = new System.Drawing.Size(280, 36);
            this.projectDesc.TabIndex = 6;
            this.projectDesc.Text = "Project Description";
            // 
            // projectNametextBox
            // 
            this.projectNametextBox.Location = new System.Drawing.Point(124, 326);
            this.projectNametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectNametextBox.Name = "projectNametextBox";
            this.projectNametextBox.Size = new System.Drawing.Size(439, 44);
            this.projectNametextBox.TabIndex = 3;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Location = new System.Drawing.Point(128, 239);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(206, 36);
            this.ProjectName.TabIndex = 2;
            this.ProjectName.Text = "Project Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Project);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1683, 133);
            this.panel1.TabIndex = 7;
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project.Location = new System.Drawing.Point(32, 34);
            this.Project.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(134, 42);
            this.Project.TabIndex = 0;
            this.Project.Text = "Project";
            // 
            // ProjectViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1134);
            this.Controls.Add(this.ProjecttabControl);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectViewForm";
            this.Text = "ProjectViewForm";
            this.ProjecttabControl.ResumeLayout(false);
            this.ProjectList.ResumeLayout(false);
            this.ProjectList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectdataGridView)).EndInit();
            this.ProjectDetail.ResumeLayout(false);
            this.ProjectDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProjecttabControl;
        private System.Windows.Forms.TabPage ProjectList;
        private System.Windows.Forms.Button projectDeletebutton;
        private System.Windows.Forms.Button projectEditbutton;
        private System.Windows.Forms.Button projectAddbutton;
        private System.Windows.Forms.DataGridView projectdataGridView;
        private System.Windows.Forms.Button projectSearchbutton;
        private System.Windows.Forms.TextBox projectSearchtextBox;
        private System.Windows.Forms.TabPage ProjectDetail;
        private System.Windows.Forms.TextBox projectIdtextBox1;
        private System.Windows.Forms.Button Projectcancelbutton;
        private System.Windows.Forms.Button Projectsavebutton;
        private System.Windows.Forms.Label Created;
        private System.Windows.Forms.TextBox projectdesctextBox;
        private System.Windows.Forms.Label projectDesc;
        private System.Windows.Forms.TextBox projectNametextBox;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.DateTimePicker projectdateTimePicker1;
    }
}