using _3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.View
{
    public interface RequirementView
    {
        string ProjectID { get; set; }
        string ReqID { get; set; }
        string ReqName { get; set; }
        bool ReqStatus { get; set; }
        string ReqVersion { get; set; }
        DateTime ReqCreatedDate { get; set; }
        DateTime ReqUpdatedDate { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Event Handlers
        event EventHandler SearchRequirementEvent;
        event EventHandler AddRequirementEvent;
        event EventHandler EditRequirementEvent;
        event EventHandler DeleteRequirementEvent;
        event EventHandler SaveRequirementEvent;
        event EventHandler CancelRequirementEvent;
        

        //Methods
        void SetRequirementListBindingSource(BindingSource requirementList);

        void SetProjectComboBoxBindingSource(BindingSource req_projectList);
       
       
        
        void show();
        void ShowDialog();
    }
}
