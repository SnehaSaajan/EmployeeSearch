using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Designation { get; set; }
        public string Band { get; set; }
    }
}
