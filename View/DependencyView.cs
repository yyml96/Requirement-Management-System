using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.View
{
    public interface DependencyView
    {
        string ReqID { get; set; }
        string DepID { get; set; }
        string DepName { get; set; }
        string Dep_RepID { get; set; }
        DateTime DepCreatedDate { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //event handlers
        event EventHandler SearchDependencyEvent;
        event EventHandler AddDependencyEvent;
        event EventHandler EditDependencyEvent;
        event EventHandler DeleteDependencyEvent;
        event EventHandler SaveDependencyEvent;
        event EventHandler CancelDependencyEvent;

        //methods
        void SetDependencyListBindingSource(BindingSource dependencyList);
        void SetRequirementComboBoxBindingSource(BindingSource dep_reqList);
        void show();
        void ShowDialog();
    }
}
