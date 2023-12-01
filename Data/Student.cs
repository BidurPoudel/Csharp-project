using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_project.Data
    {
    internal class Student
        {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public int Semester { get; set; }
        public Guid Guid { get; set; }
        }
    }
