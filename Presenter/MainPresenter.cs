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
    public class MainPresenter
    {
        private IMainView mainView;

        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.UserViewForm += UserViewForm;
            this.mainView.ProjectViewForm += ProjectViewForm;
            this.mainView.RequirementViewForm += RequirementViewForm;
            this.mainView.DependencyViewForm += DependencyViewForm;
        }

        private void DependencyViewForm(object sender, EventArgs e)
        {
            DependencyView view = new DependencyViewForm();
            IDependencyRepo repo = new DependencyRepo();
            new DependencyPresenter(repo, view);
            view.ShowDialog();
        }

        private void RequirementViewForm(object sender, EventArgs e)
        {
            RequirementView view = new RequirementViewForm();
            IRequirementRepo repo = new RequirementRepo();
            new RequirementPresenter(repo, view);
            view.ShowDialog();
        }

        private void ProjectViewForm(object sender, EventArgs e)
        {
            ProjectView view = new ProjectViewForm();
            IProjectRepo repo = new ProjectRepo();
            new ProjectPresenter(view, repo);
            view.ShowDialog();
        }

        private void UserViewForm(object sender, EventArgs e)
        {
            UserView view = new UserViewForm();
            IUserRepo repo = new UserRepo();
            new UserPresenter(view, repo);
            view.ShowDialog();
        }
    }
}
