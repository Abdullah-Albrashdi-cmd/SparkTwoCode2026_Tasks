using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public int DepartmentNum { get; set; }

        //CONTROLS
        [ForeignKey("DD")]
        public int DepartmentId { get; set; }

        public Department DD { get; set; }

        //WORKS_ON
        public List<WorksOnEmpProj> wo { get; set; }
    }
}
