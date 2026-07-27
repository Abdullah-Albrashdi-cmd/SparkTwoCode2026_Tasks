using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentMgr_ssn { get; set; }
        public int DepartmentMgr_start_date { get; set; }

        //WORKS_FOR
        [InverseProperty("D")]
        public List<Employee> Employees { get; set; }

        //CONTROLS
        public List<Project> Projects { get; set; }

        //MANAGES
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime ManageStartDate { get; set; }

        




    }
}
