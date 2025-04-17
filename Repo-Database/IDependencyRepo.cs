using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Model;

namespace _3.Repo_Database
{
    public interface IDependencyRepo
    {
        void AddDependency(Dependency dependency);
        void EditDependency(Dependency dependency);
        void DeleteDependency(int id);
        IEnumerable<Dependency> GetDependencyByValue(string value);
        IEnumerable<Dependency> GetAllDependencies();
        IEnumerable<Requirement> GetRequirements();
    }
}
