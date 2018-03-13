using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class EmployeeViewModel
    {
       
        [Display(Name = "Employee Number")]
        public int EmployeeNumber { get; set; }
        
        public string Name { get; set; }

        [Display(Name = "Date Of Joining")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DateOfJoining { get; set; }
       
        public string Designation { get; set; }
       
        public string Band { get; set; }


    }
}