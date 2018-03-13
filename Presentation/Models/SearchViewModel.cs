using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class SearchViewModel
    {
        [Required]
        [Display(Name = "Search Field")]
        public string Field { get; set; }
        [Required]
        [Display(Name = "Search Type")]
        public string Type { get; set; }
      
        [Display(Name = "Search Value")]
        public string Value { get; set; }
     
        [Display(Name = "Search Date")]
        public DateTime FromDate { get; set; }
        
        [Display(Name = "To Date")]
        public DateTime ToDate { get; set; }
        public bool IsNot { get; set; }

    }
}