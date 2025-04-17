using _3.Model;
using _3.Repo_Database;
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
    public partial class RequirementViewForm : Form, RequirementView
    {
        private string message;
        private bool isEdit;
        private bool isSuccessful;

        public RequirementViewForm()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
            ReqtabControl.TabPages.Remove(ReqDetail);
            ReqtabControl.TabPages.Remove(ReqCmd);
            reqIdtextBox1.Enabled = false;
            reqIdtextBox1.Visible = false;
            req_projectIDtextBox1.Enabled = false;
            req_projectIDtextBox1.Visible = false;
            reqcreateddateTimePicker1.Visible = false;

        }

        private void AssociateAndRaiseEvent()
        {
            reqSearchbutton.Click += delegate { SearchRequirementEvent?.Invoke(this, EventArgs.Empty); };
            reqSearchtextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchRequirementEvent?.Invoke(this, EventArgs.Empty);
            };

            reqAddbutton.Click += delegate
            {
                AddRequirementEvent?.Invoke(this, EventArgs.Empty);
                ReqtabControl.TabPages.Remove(ReqList);
                ReqtabControl.TabPages.Remove(ReqCmd);
                ReqtabControl.TabPages.Add(ReqDetail);
                reqUpdateddateTimePicker1.Visible = false;
                req_updated_at.Visible = false;
                ReqDetail.Text = "Add New Requirement";
            };

            reqEditbutton.Click += delegate
            {
                EditRequirementEvent?.Invoke(this, EventArgs.Empty);
                ReqtabControl.TabPages.Remove(ReqList);
                ReqtabControl.TabPages.Remove(ReqCmd);
                reqUpdateddateTimePicker1.Visible = true;
                req_updated_at.Visible = true;
                ReqtabControl.TabPages.Add(ReqDetail);
                ReqDetail.Text = "Edit Requirement";
            };

            reqDeletebutton.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected requirement?", "Warning",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRequirementEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            reqsavebutton.Click += delegate
            {
                SaveRequirementEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    ReqtabControl.TabPages.Remove(ReqDetail);
                    ReqtabControl.TabPages.Remove(ReqCmd);
                    
                    ReqtabControl.TabPages.Add(ReqList);
                }
                MessageBox.Show(message);
            };

            reqcancelbutton.Click += delegate
            {
                CancelRequirementEvent?.Invoke(this, EventArgs.Empty);
                ReqtabControl.TabPages.Remove(ReqDetail);
                ReqtabControl.TabPages.Add(ReqList);
               
            };
        }

        string RequirementView.ProjectID
        {
            get { return ProjectselectcomboBox1.SelectedValue.ToString(); }
            set { ProjectselectcomboBox1.SelectedValue = value; }
        }
        string RequirementView.ReqID
        {
            get { return reqIdtextBox1.Text; }
            set { reqIdtextBox1.Text = value; }
        }

        string RequirementView.ReqName
        {
            get { return reqNametextBox.Text; }
            set { reqNametextBox.Text = value; }
        }

        string RequirementView.ReqVersion
        {
            get { return reqVersiontextBox.Text; }
            set { reqVersiontextBox.Text = value; }
        }

        bool RequirementView.ReqStatus
        {
            get { return reqStatuscomboBox1.SelectedItem.ToString() == "Active" ? true : false; }
            set { reqStatuscomboBox1.SelectedItem = value ? "Active" : "Inactive"; }
        }

        private DateTime reqCreatedDate;
        
        DateTime RequirementView.ReqCreatedDate
        {
            get { return reqCreatedDate; }
            set { reqCreatedDate = value; }
        }

        DateTime RequirementView.ReqUpdatedDate
        {
            get { return reqUpdateddateTimePicker1.Value; }
            set { reqUpdateddateTimePicker1.Value = value; }
        }

        public string SearchValue
        {
            get { return reqSearchtextBox.Text; }
            set { reqSearchtextBox.Text = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
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
       

        //Event Handlers
        public event EventHandler SearchRequirementEvent;
        public event EventHandler AddRequirementEvent;
        public event EventHandler EditRequirementEvent;
        public event EventHandler DeleteRequirementEvent;
        public event EventHandler SaveRequirementEvent;
        public event EventHandler CancelRequirementEvent;
        

        public void SetRequirementListBindingSource(BindingSource requirementList)
        {
            ReqdataGridView.DataSource = requirementList;
            ProjectselectcomboBox1.DataSource = requirementList;
            ProjectselectcomboBox1.DisplayMember = "Requirement_name";           
        }

       

        public void SetProjectComboBoxBindingSource(BindingSource req_projectList)
        {
            ProjectselectcomboBox1.DataSource = req_projectList;
            ProjectselectcomboBox1.DisplayMember = "Project_name";
            ProjectselectcomboBox1.ValueMember = "Project_id";
            //valuemember set the value of the combobox to the value of the selected item id instead of the name
        }

       

        

        public void show()
        {
            this.ShowDialog();
        }

        void RequirementView.ShowDialog()
        {
            this.Hide();
        }

       
    }
}
