using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.View
{
    public interface IMainView
    {
        event EventHandler UserViewForm;
        event EventHandler ProjectViewForm;
        event EventHandler DependencyViewForm;
        event EventHandler RequirementViewForm;
    }
}
