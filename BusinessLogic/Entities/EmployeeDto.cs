using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class EmployeeDto
    {
        public string Field { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsNot { get; set; }
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Designation { get; set; }
        public string Band { get; set; }
    }
}
