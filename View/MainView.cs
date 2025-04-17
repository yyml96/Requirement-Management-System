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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnUser.Click += delegate { UserViewForm?.Invoke(this, EventArgs.Empty); };
            btnProject.Click += delegate { ProjectViewForm?.Invoke(this, EventArgs.Empty); };
            btnDependency.Click += delegate { DependencyViewForm?.Invoke(this, EventArgs.Empty); };
            btnRequirement.Click += delegate { RequirementViewForm?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler UserViewForm;
        public event EventHandler ProjectViewForm;
        public event EventHandler DependencyViewForm;
        public event EventHandler RequirementViewForm;
    }
}
