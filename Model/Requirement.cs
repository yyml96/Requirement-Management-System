using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Model
{
    public class Requirement
    {
        private int project_id;
        private int requirement_id;
        private string requirement_name;
        private bool requirement_status;
        private string requirement_version;
        private DateTime requirement_created_date;
        private DateTime requirement_updated_date;

        public int Project_id
        {
            get { return project_id; }
            set { project_id = value; }
        }
        public int Requirement_id
        {
            get { return requirement_id; }
            set { requirement_id = value; }
        }

        public string Requirement_name
        {
            get { return requirement_name; }
            set { requirement_name = value; }
        }

        public bool Requirement_status
        {
            get { return requirement_status; }
            set { requirement_status = value; }
        }

        public string Requirement_version
        {
            get { return requirement_version; }
            set { requirement_version = value; }
        }

        public DateTime Requirement_created_date
        {
            get { return requirement_created_date; }
            set { requirement_created_date = value; }
        }

        public DateTime Requirement_updated_date
        {
            get { return requirement_updated_date; }
            set { requirement_updated_date = value; }
        }

    }
}
