using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(ProjectId))]
    public class WorksOnEmpProj
    {
        [ForeignKey("emp")]
        public int EmployeeId { get; set; }
        public Employee emp {  get; set; }

        [ForeignKey("Proj")]
        public int ProjectId { get; set; }
        public Project Proj { get; set; }

        public int Hours { get; set; }


    }
}
