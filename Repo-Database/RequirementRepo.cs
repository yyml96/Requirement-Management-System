using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Model;
using MySql.Data.MySqlClient;

namespace _3.Repo_Database
{
    public class RequirementRepo : IRequirementRepo
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=ms;";
        public void AddRequirement(Requirement requirement)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO requirement (project_id, req_name, req_status, req_version, req_created_at, req_updated_at) VALUES (@project_id, @requirement_name, @requirement_status, @requirement_version, @requirement_created_date, @requirement_updated_date)";
                    command.Parameters.Add("@project_id", MySqlDbType.Int32).Value = requirement.Project_id;
                    command.Parameters.Add("@requirement_name", MySqlDbType.VarChar).Value = requirement.Requirement_name;
                    command.Parameters.Add("@requirement_status", MySqlDbType.Bit).Value = requirement.Requirement_status;
                    command.Parameters.Add("@requirement_version", MySqlDbType.VarChar).Value = requirement.Requirement_version;
                    command.Parameters.Add("@requirement_created_date", MySqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@requirement_updated_date", MySqlDbType.DateTime).Value = requirement.Requirement_updated_date;
                    command.ExecuteNonQuery();
                }
            }
        }   

        public void EditRequirement(Requirement requirement)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE requirement SET project_id = @project_id, req_name = @req_name, req_status = @req_status, req_version = @requirement_version, req_created_at =@req_created_at, req_updated_at =@req_updated_at WHERE req_id = @req_id";
                command.Parameters.Add("@project_id", MySqlDbType.Int32).Value = requirement.Project_id;
                command.Parameters.Add("@req_id", MySqlDbType.Int32).Value = requirement.Requirement_id;
                command.Parameters.Add("@req_name", MySqlDbType.VarChar).Value = requirement.Requirement_name;
                command.Parameters.Add("@req_status", MySqlDbType.Bit).Value = requirement.Requirement_status;
                command.Parameters.Add("@requirement_version", MySqlDbType.VarChar).Value = requirement.Requirement_version;
                command.Parameters.Add("@req_created_at", MySqlDbType.DateTime).Value = requirement.Requirement_created_date;
                command.Parameters.Add("@req_updated_at", MySqlDbType.DateTime).Value = requirement.Requirement_updated_date;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteRequirement(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM requirement WHERE req_id = @req_id";
                command.Parameters.Add("@req_id", MySqlDbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Requirement> GetRequirementByValue(string value)
        {
            var requirementList = new List<Requirement>();
            int Id = int.TryParse(value, out int prasedId) ? prasedId : 0;
            string Requirement_name = value;
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Requirement WHERE req_id = @req_id OR req_name LIKE CONCAT(@req_name, '%') ORDER BY req_id ASC";
                command.Parameters.Add("@req_id", MySqlDbType.Int32).Value = Id;
                command.Parameters.Add("@req_name", MySqlDbType.VarChar).Value = Requirement_name;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var requirementModel = new Requirement();
                        requirementModel.Project_id = Convert.ToInt32(reader["project_id"]);
                        requirementModel.Requirement_id = Convert.ToInt32(reader["req_id"]);
                        requirementModel.Requirement_name = reader["req_name"].ToString();
                        requirementModel.Requirement_status = Convert.ToBoolean(reader["req_status"]);
                        requirementModel.Requirement_version = reader["req_version"].ToString();
                        requirementModel.Requirement_created_date = Convert.ToDateTime(reader["req_created_at"]);
                        requirementModel.Requirement_updated_date = Convert.ToDateTime(reader["req_updated_at"]);
                        requirementList.Add(requirementModel);
                    
                    }
                }
            }

            return requirementList;
        }

        public IEnumerable<Requirement> GetAllRequirements()
        {
            var requirementList = new List<Requirement>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT project_id, req_id, req_name, req_status, req_version, req_created_at, req_updated_at FROM Requirement ORDER BY req_id ASC";

                
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var requirement = new Requirement();
                            requirement.Project_id = Convert.ToInt32(reader["project_id"]);
                            requirement.Requirement_id = Convert.ToInt32(reader["req_id"]);
                            requirement.Requirement_name = reader["req_name"].ToString();
                            requirement.Requirement_status = Convert.ToBoolean(reader["req_status"]);
                            requirement.Requirement_version = reader["req_version"].ToString();
                            requirement.Requirement_created_date = Convert.ToDateTime(reader["req_created_at"]);
                            requirement.Requirement_updated_date = Convert.ToDateTime(reader["req_updated_at"]);
                   
                            requirementList.Add(requirement);
                        }
                    }
                
            }
            return requirementList;
        }

        public IEnumerable<Project> GetProjects()
        {
            var req_projectList = new List<Project>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT project_id, project_name FROM project";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var project = new Project();
                        project.Project_id = Convert.ToInt32(reader["project_id"]);
                        project.Project_name = reader["project_name"].ToString();
                        req_projectList.Add(project);
                    }
                }
            }
            return req_projectList;
        }
    }
}
