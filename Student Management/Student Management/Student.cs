using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StudentCode { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int PersonID { get; set; }
        public string Class { get; set; }
    }
}
