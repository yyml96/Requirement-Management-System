using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Model;

namespace _3.Repo_Database
{
    public interface IProjectRepo
    {
        void AddProject(Project project);
        void EditProject(Project project);
        void DeleteProject(int id);
        IEnumerable<Project> GetProjectByValue(string value);
        IEnumerable<Project> GetAllProjects();

    }
}
