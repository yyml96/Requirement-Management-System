using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.Model;
using _3.Repo_Database;
using _3.View;

namespace _3.Presenter
{
    public class RequirementPresenter
    {
        private IRequirementRepo requirementRepo;
        private BindingSource req_projectBindingSource;
        private RequirementView requirementView;
        private BindingSource requirementBindingSource;
        private IEnumerable<Requirement> requirementList;
        private IEnumerable<Project> req_projectList;
        private Requirement requirement;


        public RequirementPresenter(IRequirementRepo requirementRepo, RequirementView requirementView)
        {
            this.requirementRepo = requirementRepo;

            this.requirementView = requirementView;
            this.requirementBindingSource = new BindingSource();
            this.req_projectBindingSource = new BindingSource();

            this.requirementView.AddRequirementEvent += AddRequirement;
            this.requirementView.EditRequirementEvent += EditRequirement;
            this.requirementView.DeleteRequirementEvent += DeleteRequirement;
            this.requirementView.SaveRequirementEvent += SaveRequirement;
            this.requirementView.CancelRequirementEvent += CancelRequirement;
            this.requirementView.SearchRequirementEvent += SearchRequirement;



            this.requirementView.SetRequirementListBindingSource(requirementBindingSource);
            this.requirementView.SetProjectComboBoxBindingSource(req_projectBindingSource);

            LoadProjects();
            LoadAllRequirementsList();
            this.requirementView.show();
        }

        private void LoadProjects()
        {
            req_projectList = requirementRepo.GetProjects();
            req_projectBindingSource.DataSource = req_projectList;
        }

        private void AddRequirement(object sender, EventArgs e)
        {
            requirementView.IsEdit = false;
        }

        private void EditRequirement(object sender, EventArgs e)
        {
            requirement = (Requirement)requirementBindingSource.Current;          
            requirementView.ProjectID = requirement.Project_id.ToString();
            requirementView.ReqID = requirement.Requirement_id.ToString();
            requirementView.ReqName = requirement.Requirement_name;
            requirementView.ReqStatus = requirement.Requirement_status;
            requirementView.ReqVersion = requirement.Requirement_version;
            requirementView.ReqCreatedDate = requirement.Requirement_created_date;
            requirementView.ReqUpdatedDate = requirement.Requirement_updated_date;
            requirementView.IsEdit = true;
        }

        private void DeleteRequirement(object sender, EventArgs e)
        {
            try
            {
                requirement = (Requirement)requirementBindingSource.Current;
                requirementRepo.DeleteRequirement(requirement.Requirement_id);
                requirementView.IsSuccessful = true;
                requirementView.Message = "Requirement deleted successfully";
                LoadAllRequirementsList();

            }
            catch (Exception ex)
            {
                
                requirementView.IsSuccessful = false;
                requirementView.Message = "An error occured";
                
            }
        }

        private void SaveRequirement(object sender, EventArgs e)
        {
            
    
            var requirement = new Requirement();
            requirement.Project_id = Convert.ToInt32(requirementView.ProjectID);
            requirement.Requirement_id = Convert.ToInt32(requirementView.ReqID);
            requirement.Requirement_name = requirementView.ReqName;
            requirement.Requirement_status = requirementView.ReqStatus;
            requirement.Requirement_version = requirementView.ReqVersion;
            requirement.Requirement_created_date = requirementView.ReqCreatedDate;
            requirement.Requirement_updated_date = requirementView.ReqUpdatedDate;
            try
            {
                if (requirementView.IsEdit)
                {
                    
                    requirementRepo.EditRequirement(requirement);
                    requirementView.Message = "Requirement updated successfully";
                }
                else
                {
                    requirementRepo.AddRequirement(requirement);
                    requirementView.Message = "Requirement added successfully";
                }
                requirementView.IsSuccessful = true;
                LoadProjects();
                LoadAllRequirementsList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                requirementView.IsSuccessful = false;
                requirementView.Message = ex.Message;
            }
        }

        private void CancelRequirement(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SearchRequirement(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.requirementView.SearchValue);
            if (emptyValue == false)
                requirementList = requirementRepo.GetRequirementByValue(this.requirementView.SearchValue);

            else requirementList = requirementRepo.GetAllRequirements();
            requirementBindingSource.DataSource = requirementList;
        }

       

        private void LoadAllRequirementsList()
        {
            requirementList = requirementRepo.GetAllRequirements();
            requirementBindingSource.DataSource = requirementList;
        }

        private void CleanviewFields()
        {
            requirementView.ReqID = "0";
            requirementView.ReqName = "";
            requirementView.ReqStatus = false;
            requirementView.ReqVersion = "";
            requirementView.ReqCreatedDate = DateTime.Now;
            requirementView.ReqUpdatedDate = DateTime.Now;

        }
        
    }
}
