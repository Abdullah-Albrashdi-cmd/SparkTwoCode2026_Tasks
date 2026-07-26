using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentLocation { get; set; }
        public int DepartmentMgr_ssn { get; set; }
        public int DepartmentMgr_start_date { get; set; }


    }
}
