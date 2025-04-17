using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Model
{
    public class Dependency
    {
        private int dependency_id;
        private string dependency_name;
        private DateTime dependency_created_date;
        private int requirement_id;
        private int dep_rep_id;

        public int Dependency_id
        {
            get { return dependency_id; }
            set { dependency_id = value; }
        }

        public string Dependency_name
        {
            get { return dependency_name; }
            set { dependency_name = value; }
        }

        public DateTime Dependency_created_date
        {
            get { return dependency_created_date; }
            set { dependency_created_date = value; }
        }

        public int Requirement_id
        {
            get { return requirement_id; }
            set { requirement_id = value; }
        }

        public int Dependency_rep_id
        {
            get { return dep_rep_id; }
            set { dep_rep_id = value; }
        }
    }
}
