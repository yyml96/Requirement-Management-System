using _3.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Repo_Database
{
    public class ProjectRepo : IProjectRepo
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=ms;";
        public void AddProject(Project project)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into project (project_name, project_description, project_created_at) values (@project_name, @project_description, @project_created_date)";
                    command.Parameters.Add("@project_name", MySqlDbType.VarChar).Value = project.Project_name;
                    command.Parameters.Add("@project_description", MySqlDbType.VarChar).Value = project.Project_description;
                    command.Parameters.Add("@project_created_date", MySqlDbType.DateTime).Value = project.Project_created_date;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProject(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM project WHERE project_id = @project_id";
                command.Parameters.Add("@project_id", MySqlDbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void EditProject(Project project)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update project set project_name = @project_name, project_description = @project_description, project_created_at = @project_created_date where project_id = @project_id";
                command.Parameters.Add("@project_id", MySqlDbType.Int32).Value = project.Project_id;
                command.Parameters.Add("@project_name", MySqlDbType.VarChar).Value = project.Project_name;
                command.Parameters.Add("@project_description", MySqlDbType.VarChar).Value = project.Project_description;
                command.Parameters.Add("@project_created_date", MySqlDbType.DateTime).Value = project.Project_created_date;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Project> GetAllProjects()
        {
            var projectList = new List<Project>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT project_id, project_name, project_description, project_created_at FROM project";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var projectModel = new Project();
                        projectModel.Project_id = Convert.ToInt32(reader["project_id"]);
                        projectModel.Project_name = reader["project_name"].ToString();
                        projectModel.Project_description = reader["project_description"].ToString();
                        projectModel.Project_created_date = Convert.ToDateTime(reader["project_created_at"]);

                        projectList.Add(projectModel);
                    }
                }
            }
            return projectList;
        }

        public IEnumerable<Project> GetProjectByValue(string value)
        {
            var projectList = new List<Project>();
            int Id = int.TryParse(value, out int prasedId) ? prasedId : 0;
            string projectName = value;
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM project WHERE project_id = @project_id OR project_name LIKE CONCAT(@project_name, '%') ORDER BY project_id ASC";
                command.Parameters.Add("@project_id", MySqlDbType.Int32).Value = Id;
                command.Parameters.Add("@project_name", MySqlDbType.VarChar).Value = projectName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var projectModel = new Project();
                        projectModel.Project_id = Convert.ToInt32(reader["project_id"]);
                        projectModel.Project_name = reader["project_name"].ToString();
                        projectModel.Project_description = reader["project_description"].ToString();
                        projectModel.Project_created_date = Convert.ToDateTime(reader["project_created_at"]);
                        projectList.Add(projectModel);
                    }
                }
            }
            return projectList;
        }
    }
}
