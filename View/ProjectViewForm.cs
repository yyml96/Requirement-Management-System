using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3.View
{
    public partial class ProjectViewForm : Form, ProjectView
    {
        private string message;
        private bool isEdit;
        private bool isSuccessful;

        public ProjectViewForm()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
            ProjecttabControl.TabPages.Remove(ProjectDetail);
            projectIdtextBox1.Enabled = false;
            projectIdtextBox1.Visible = false;
        }

        private void AssociateAndRaiseEvent()
        {
            projectSearchbutton.Click += delegate { SearchProjectEvent?.Invoke(this, EventArgs.Empty); };
            projectNametextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchProjectEvent?.Invoke(this, EventArgs.Empty);
            };

            projectAddbutton.Click += delegate
            {
                AddProjectEvent?.Invoke(this, EventArgs.Empty);
                ProjecttabControl.TabPages.Remove(ProjectList);
                ProjecttabControl.TabPages.Add(ProjectDetail);
                ProjectDetail.Text = "Add New Project";
            };

            projectEditbutton.Click += delegate
            {
                EditProjectEvent?.Invoke(this, EventArgs.Empty);
                ProjecttabControl.TabPages.Remove(ProjectList);
                ProjecttabControl.TabPages.Add(ProjectDetail);
                ProjectDetail.Text = "Edit Project";
            };

            projectDeletebutton.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected project?", "Warning",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteProjectEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            Projectsavebutton.Click += delegate
            {    
                SaveProjectEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    ProjecttabControl.TabPages.Remove(ProjectDetail);
                    ProjecttabControl.TabPages.Add(ProjectList);
                }
                MessageBox.Show(message);
            };

            Projectcancelbutton.Click += delegate
            {
                CancelProjectEvent?.Invoke(this, EventArgs.Empty); 
                ProjecttabControl.TabPages.Remove(ProjectDetail);
                ProjecttabControl.TabPages.Add(ProjectList);
            };
        }

        string ProjectView.ProjectId
        {
            get { return projectIdtextBox1.Text; }
            set { projectIdtextBox1.Text = value; }
        }

        string ProjectView.ProjectName
        {
            get { return projectNametextBox.Text; }
            set { projectNametextBox.Text = value; }
        }

        string ProjectView.ProjectDescription
        {
            get { return projectdesctextBox.Text; }
            set { projectdesctextBox.Text = value; }
        }

        DateTime ProjectView.ProjectCreatedDate
        {
            get { return projectdateTimePicker1.Value; }
            set { projectdateTimePicker1.Value = value; }
        }

        public string SearchValue
        {
            get { return projectSearchtextBox.Text; }
            set { projectSearchtextBox.Text = value; }
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

        // Event Handlers
        public event EventHandler SearchProjectEvent;
        public event EventHandler AddProjectEvent;
        public event EventHandler EditProjectEvent;
        public event EventHandler DeleteProjectEvent;
        public event EventHandler SaveProjectEvent;
        public event EventHandler CancelProjectEvent;

        public void SetProjectListBindingSource(BindingSource projectList)
        {
            projectdataGridView.DataSource = projectList;
        }

        public void show()
        {
            this.ShowDialog();
        }

        void ProjectView.ShowDialog()
        {
            this.Hide();
        }



    }
}
