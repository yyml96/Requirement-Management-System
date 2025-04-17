using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3.Model;
using System.Threading.Tasks;


namespace _3.Repo_Database
{
    public interface IRequirementRepo
    {
        void AddRequirement(Requirement requirement);
        void EditRequirement(Requirement requirement);
        void DeleteRequirement(int id);
        IEnumerable<Requirement> GetRequirementByValue(string value);
        IEnumerable<Requirement> GetAllRequirements();
        IEnumerable<Project> GetProjects();
    }
}
