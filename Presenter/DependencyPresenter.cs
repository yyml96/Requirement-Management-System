using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Model;
using _3.Repo_Database;
using _3.View;
using System.Windows.Forms;

namespace _3.Presenter
{
    public class DependencyPresenter
    {
        private IDependencyRepo dependencyRepo;
        private BindingSource dependencyBindingSource;
        private DependencyView dependencyView;
        private BindingSource dep_requirementBindingSource;
        private IEnumerable<Dependency> dependencyList;
        private IEnumerable<Requirement> dep_requirementList;
        private Dependency dependency;

        public DependencyPresenter(IDependencyRepo dependencyRepo, DependencyView dependencyView)
        {
            this.dependencyRepo = dependencyRepo;
            this.dependencyView = dependencyView;
            this.dependencyBindingSource = new BindingSource();
            this.dep_requirementBindingSource = new BindingSource();
            this.dependencyView.AddDependencyEvent += AddDependency;
            this.dependencyView.EditDependencyEvent += EditDependency;
            this.dependencyView.DeleteDependencyEvent += DeleteDependency;
            this.dependencyView.SaveDependencyEvent += SaveDependency;
            this.dependencyView.CancelDependencyEvent += CancelDependency;
            this.dependencyView.SearchDependencyEvent += SearchDependency;

            this.dependencyView.SetDependencyListBindingSource(dependencyBindingSource);
            this.dependencyView.SetRequirementComboBoxBindingSource(dep_requirementBindingSource);

            LoadRequirements();
            LoadAllDependenciesList();
            this.dependencyView.show();
        }

        private void LoadRequirements()
        {
            dep_requirementList = dependencyRepo.GetRequirements();
            dep_requirementBindingSource.DataSource = dep_requirementList;
        }

        private void LoadAllDependenciesList()
        {
            dependencyList = dependencyRepo.GetAllDependencies();
            dependencyBindingSource.DataSource = dependencyList;
        }

        private void CleanviewFields()
        {
            dependencyView.DepID = "0";
            dependencyView.DepName = "";
            dependencyView.DepCreatedDate = DateTime.Now;
            dependencyView.ReqID = "";
        }

        private void AddDependency(object sender, EventArgs e)
        {
            dependencyView.IsEdit = false;
        }

        private void EditDependency(object sender, EventArgs e)
        {
            dependency = (Dependency)dependencyBindingSource.Current;
            dependencyView.DepID = dependency.Dependency_id.ToString();
            dependencyView.DepName = dependency.Dependency_name;
            dependencyView.DepCreatedDate = dependency.Dependency_created_date;
            dependencyView.ReqID = dependency.Requirement_id.ToString();
            
            dependencyView.IsEdit = true;
        }

        private void DeleteDependency(object sender, EventArgs e)
        {
            try
            {
                var dependency = (Dependency)dependencyBindingSource.Current;
                dependencyRepo.DeleteDependency(dependency.Dependency_id);
                dependencyView.IsSuccessful = true;
                dependencyView.Message = "Dependency deleted successfully";
                LoadAllDependenciesList();
            }
            catch (Exception ex)
            {
                dependencyView.IsSuccessful = false;
                dependencyView.Message = ex.Message;
            }
        }

        private void SaveDependency(object sender, EventArgs e)
        {
            var dependency = new Dependency();
            dependency.Dependency_id = Convert.ToInt32(dependencyView.DepID);
            dependency.Dependency_name = dependencyView.DepName;
            dependency.Dependency_created_date = dependencyView.DepCreatedDate;
            dependency.Requirement_id = Convert.ToInt32(dependencyView.ReqID);
            try
            {
                if (dependencyView.IsEdit)
                {
                    
                    dependencyRepo.EditDependency(dependency);
                    dependencyView.Message = " Dependency updated successfully";
                }
                else
                {
                    dependencyRepo.AddDependency(dependency);
                    dependencyView.Message = " Dependency added successfully";
                }
                dependencyView.IsSuccessful = true;
                LoadRequirements();
                LoadAllDependenciesList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                dependencyView.IsSuccessful = false;
                dependencyView.Message = ex.Message;
            }
        }

        private void CancelDependency(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SearchDependency(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.dependencyView.SearchValue);
            if (emptyValue == false)
                dependencyList = dependencyRepo.GetDependencyByValue(this.dependencyView.SearchValue);

            else dependencyList = dependencyRepo.GetAllDependencies();
            dependencyBindingSource.DataSource = dependencyList;

        }

        
    }
}
