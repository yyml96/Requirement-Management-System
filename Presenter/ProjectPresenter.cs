using _3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Repo_Database;
using System.Windows.Forms;
using _3.Model;

namespace _3.Presenter
{
    public class ProjectPresenter
    {
        private IProjectRepo projectRepo;
        private ProjectView projectView;
        private BindingSource projectBindingSource;
        private IEnumerable<Model.Project> projectList;
        private Model.Project project;

        public ProjectPresenter(ProjectView projectView, IProjectRepo projectRepo)
        {
            this.projectView = projectView;
            this.projectRepo = projectRepo;
            this.projectBindingSource = new BindingSource();
            this.projectView.AddProjectEvent += AddProject;
            this.projectView.EditProjectEvent += EditProject;
            this.projectView.DeleteProjectEvent += DeleteProject;
            this.projectView.SearchProjectEvent += SearchProject;
            this.projectView.SaveProjectEvent += SaveProject;
            this.projectView.CancelProjectEvent += CancelProject;

            this.projectView.SetProjectListBindingSource(projectBindingSource);
            LoadAllProjectsList();
            this.projectView.show();
        }

        private void CancelProject(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveProject(object sender, EventArgs e)
        {
            var project = new Project();
            project.Project_id = Convert.ToInt32(projectView.ProjectId);
            project.Project_name = projectView.ProjectName;
            project.Project_description = projectView.ProjectDescription;
            project.Project_created_date = projectView.ProjectCreatedDate;
            try
            {
                new ModelDataValidation().Validate(project);
                if (projectView.IsEdit)
                {
                    projectRepo.EditProject(project);
                    projectView.Message = " Project updated successfully";
                }
                else
                {
                    projectRepo.AddProject(project);
                    projectView.Message = " Project added successfully";
                }
                projectView.IsSuccessful = true;
                LoadAllProjectsList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                projectView.IsSuccessful = false;
                projectView.Message = ex.Message;
            }
        }

        private void LoadAllProjectsList()
        {
            projectList = projectRepo.GetAllProjects();
            projectBindingSource.DataSource = projectList;
        }

        private void CleanviewFields()
        {             
            projectView.ProjectId = "0";
            projectView.ProjectName = "";
            projectView.ProjectDescription = "";
            projectView.ProjectCreatedDate = DateTime.Now;
        }

        private void AddProject(object sender, EventArgs e)
        {
            projectView.IsEdit = false;
        }

        private void EditProject(object sender, EventArgs e)
        {
            project = (Project)projectBindingSource.Current;
            projectView.ProjectId = project.Project_id.ToString();
            projectView.ProjectName = project.Project_name;
            projectView.ProjectDescription = project.Project_description;
            projectView.ProjectCreatedDate = project.Project_created_date;
            projectView.IsEdit = true;
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            try
            {
                var project = (Project)projectBindingSource.Current;
                projectRepo.DeleteProject(project.Project_id);
                projectView.IsSuccessful = true;
                projectView.Message = "Project deleted successfully";
                LoadAllProjectsList();
            }
            catch (Exception ex)
            {
                projectView.IsSuccessful = false;
                projectView.Message = "An error occured";        
            }


        }

        private void SearchProject(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.projectView.SearchValue);
            if (emptyValue == false)
                projectList = projectRepo.GetProjectByValue(this.projectView.SearchValue);

            else projectList = projectRepo.GetAllProjects();
            projectBindingSource.DataSource = projectList;
        }
    }
}

