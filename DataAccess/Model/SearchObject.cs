using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class SearchObject
    {
        public string Field { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsNot { get; set; }
    }
}
