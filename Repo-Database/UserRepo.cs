using _3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Ocsp;

namespace _3.Repo_Database
{
    public class UserRepo : IUserRepo
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=;database=ms;";
        public void AddUser(User user)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO user (username, password, email, fullname) VALUES (@username, @password, @email, @fullname)";
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@fullname", user.Fullname);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM user WHERE user_id = @user_id";
                command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void EditUser(User user)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE user SET username = @username, password = @password, email = @email, fullname = @fullname WHERE user_id = @user_id";
                command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = user.Id;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.Username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.Email;
                command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = user.Fullname;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            var userList = new List<User>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT user_id, password, username, fullname, email FROM user ORDER BY user_id ASC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new User();
                        userModel.Id = Convert.ToInt32(reader["user_id"]);
                        userModel.Username = reader["username"].ToString();
                        userModel.Password = reader["password"].ToString();
                        userModel.Fullname = reader["fullname"].ToString();
                        userModel.Email = reader["email"].ToString();

                        userList.Add(userModel);
                    }
                }
            }
            return userList;
        }

        public IEnumerable<User> GetUserByValue(string value)
        {
            var userList = new List<User>();
            int Id = int.TryParse(value, out int prasedId) ? prasedId : 0;
            string userName = value;
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM User WHERE user_id = @user_id OR username LIKE CONCAT(@username, '%') ORDER BY user_id ASC";
                command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = Id;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new User();
                        userModel.Id = Convert.ToInt32(reader["user_id"]);
                        userModel.Username = reader["username"].ToString();
                        userModel.Password = reader["password"].ToString();
                        userModel.Email = reader["email"].ToString();
                        userModel.Fullname = reader["fullname"].ToString();
                        userList.Add(userModel);
                    }
                }
            }

            return userList;
        }

        //role
        public IEnumerable<Project> GetProjects()
        {
            var role_project = new List<Project>();
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
                        role_project.Add(project);
                    }
                }
            }
            return role_project;
        }

        public void AddRole(UserRole role)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO user_role (user_id, project_id, role_name) VALUES (@user_id, @project_id, @role_name)";
                command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = role.User_id;
                command.Parameters.Add("@role_name", MySqlDbType.VarChar).Value = role.Role_name;
                
                command.Parameters.Add("@project_id", MySqlDbType.Int32).Value = role.Project_id;               
                command.ExecuteNonQuery();
            }
        }

        //sql query for retriving project, requirement, dependency, user role by user id
       /* SELECT
        p.project_name,
        r.req_name,
        d.dep_name,
        pc.`project_ comment` AS project_comment,
        rc.`req_ comment` AS requirement_comment,
        ur.role_name,
        u.username
        FROM
            `user` u
        LEFT JOIN
            user_role ur ON u.user_id = ur.user_id
        LEFT JOIN
            project p ON ur.project_id = p.project_id
        LEFT JOIN
            requirement r ON p.project_id = r.project_id
        LEFT JOIN
            dependencies d ON r.req_id = d.req_id
        LEFT JOIN
            project_comment pc ON p.project_id = pc.project_id
        LEFT JOIN
            requirement_comment rc ON r.req_id = rc.req_id
        LIMIT 25;*/

    }
}
