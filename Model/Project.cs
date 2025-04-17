using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Model
{
    public class Project
    {
        private int project_id;
        private string project_name;
        private string project_description;
        private DateTime project_created_date;

        public int Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }
        public string Project_name
        {
            get { return project_name; }
            set { project_name = value; }
        }

        public string Project_description
        {
            get { return project_description; }
            set { project_description = value; }
        }

        public DateTime Project_created_date
        {
            get { return project_created_date; }
            set { project_created_date = value; }
        }
    }
}
