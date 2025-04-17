using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class DependencyViewForm : Form, DependencyView
    {
        private string message;
        private bool isEdit;
        private bool isSuccessful;

        public DependencyViewForm()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
            DependencytabControl.TabPages.Remove(DependencyDetail);
            depIdtextBox.Enabled = false;
            depIdtextBox.Visible = false;
            dep_repcomboBox1.Visible = false;
        }

        private void AssociateAndRaiseEvent()
        {
            depSearchbutton.Click += delegate { SearchDependencyEvent?.Invoke(this, EventArgs.Empty); };
            depSearchtextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchDependencyEvent?.Invoke(this, EventArgs.Empty);
            };

            depAddbutton.Click += delegate
            {
                AddDependencyEvent?.Invoke(this, EventArgs.Empty);
                
                DependencytabControl.TabPages.Remove(DependencyList);
                DependencytabControl.TabPages.Add(DependencyDetail);
                DependencyDetail.Text = "Add New Dependency";
            };

            depEditbutton.Click += delegate
            {
                EditDependencyEvent?.Invoke(this, EventArgs.Empty);
                DependencytabControl.TabPages.Remove(DependencyList);
                DependencytabControl.TabPages.Add(DependencyDetail);
                DependencyDetail.Text = "Edit Dependency";
            };

            depDeletebutton.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected dependency?", "Warning",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDependencyEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            depsavebutton.Click += delegate
            {
                SaveDependencyEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    DependencytabControl.TabPages.Remove(DependencyDetail);
                    DependencytabControl.TabPages.Add(DependencyList);
                }
                MessageBox.Show(message);
            };

            depcancelbutton.Click += delegate
            {
                CancelDependencyEvent?.Invoke(this, EventArgs.Empty);
                DependencytabControl.TabPages.Remove(DependencyDetail);
                DependencytabControl.TabPages.Add(DependencyList);
            };
        }
        
        string DependencyView.DepID
        { 
            get { return depIdtextBox.Text; }
            set { depIdtextBox.Text = value; }
        }

        string DependencyView.DepName
        {
            get { return depNametextBox.Text; }
            set { depNametextBox.Text = value; }
        }

        DateTime DependencyView.DepCreatedDate
        {
            get { return dependencydateTimePicker.Value; }
            set { dependencydateTimePicker.Value = value; }
        }

        string DependencyView.Dep_RepID
        {
            get { return dep_repcomboBox1.Text; }
            set { dep_repcomboBox1.Text = value; }
        }

        string DependencyView.ReqID
        {
            get { return repselectioncomboBox.SelectedValue.ToString(); }
            set { repselectioncomboBox.SelectedValue = value; }
        }

        public string SearchValue
        {
            get { return depSearchtextBox.Text; }
            set { depSearchtextBox.Text = value; }
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
        public event EventHandler SearchDependencyEvent;
        public event EventHandler AddDependencyEvent;
        public event EventHandler EditDependencyEvent;
        public event EventHandler DeleteDependencyEvent;
        public event EventHandler SaveDependencyEvent;
        public event EventHandler CancelDependencyEvent;

        // Methods
        public void SetDependencyListBindingSource(BindingSource dependencyList)
        {
            depdataGridView.DataSource = dependencyList;
        }

        public void SetRequirementComboBoxBindingSource(BindingSource dep_reqList)
        {
            repselectioncomboBox.DataSource = dep_reqList;
            repselectioncomboBox.DisplayMember = "Requirement_name";
            repselectioncomboBox.ValueMember = "Requirement_id";
        }
        
        public void show()
        {
            this.ShowDialog();
        }

        void DependencyView.ShowDialog()
        {
            this.Hide();
        }
    }
}
