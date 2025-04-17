using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.View
{
    public interface ProjectView
    {
        string ProjectId { get; set; }
        string ProjectName { get; set; }
        string ProjectDescription { get; set; }
        DateTime ProjectCreatedDate { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }

        string Message { get; set; }
        

        //Event Handlers
        event EventHandler SearchProjectEvent;
        event EventHandler AddProjectEvent;
        event EventHandler EditProjectEvent;
        event EventHandler DeleteProjectEvent;   
        event EventHandler SaveProjectEvent;
        event EventHandler CancelProjectEvent;

        //Methods
        void SetProjectListBindingSource(BindingSource projectList);
        void show();
        void ShowDialog();
    }
}
