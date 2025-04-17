using _3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _3.Repo_Database
{
    public class DependencyRepo : IDependencyRepo
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=ms;";
        public void AddDependency(Dependency dependency)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO dependencies (dep_name, dep_created_at, req_id) VALUES (@dep_name, @dep_created_at, @req_id)";                   
                    command.Parameters.Add("@dep_name", MySqlDbType.VarChar).Value = dependency.Dependency_name;
                    command.Parameters.Add("@dep_created_at", MySqlDbType.DateTime).Value = dependency.Dependency_created_date;
                    command.Parameters.Add("@req_id", MySqlDbType.Int32).Value = dependency.Requirement_id;                   
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteDependency(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM dependencies WHERE dep_id = @dep_id";
                command.Parameters.Add("@dep_id", MySqlDbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void EditDependency(Dependency dependency)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE dependencies SET dep_name = @dep_name, dep_created_at = @dep_created_at, req_id = @req_id WHERE dep_id = @dep_id";
                command.Parameters.Add("@dep_id", MySqlDbType.Int32).Value = dependency.Dependency_id;
                command.Parameters.Add("@dep_name", MySqlDbType.VarChar).Value = dependency.Dependency_name;
                command.Parameters.Add("@dep_created_at", MySqlDbType.DateTime).Value = dependency.Dependency_created_date;
                command.Parameters.Add("@req_id", MySqlDbType.Int32).Value = dependency.Requirement_id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Dependency> GetAllDependencies()
        {
            var dependencyList = new List<Dependency>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM dependencies ORDER by dep_id ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dependency = new Dependency();
                        dependency.Dependency_id = Convert.ToInt32(reader["dep_id"]);
                        dependency.Dependency_name = reader["dep_name"].ToString();
                        dependency.Dependency_created_date = Convert.ToDateTime(reader["dep_created_at"]);                       
                        dependency.Requirement_id = Convert.ToInt32(reader["req_id"]);
                        dependency.Dependency_rep_id = Convert.ToInt32(reader["dep_rep_id"]);

                        dependencyList.Add(dependency);
                    }
                }
            }
            return dependencyList;
        }

        public IEnumerable<Dependency> GetDependencyByValue(string value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Requirement> GetRequirements()
        {
            var dep_reqList = new List<Requirement>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT req_id, req_name FROM Requirement";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dep_req = new Requirement();
                        dep_req.Requirement_id = Convert.ToInt32(reader["req_id"]);
                        dep_req.Requirement_name = reader["req_name"].ToString();

                        dep_reqList.Add(dep_req);
                    }
                }
            }
            return dep_reqList;
        }
    }
}
