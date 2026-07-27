using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{        
    [PrimaryKey(nameof(DependentId), nameof(DependentName))]

    public class Dependent
    {
        [Key]
        public int DependentId { get; set; }
        public string DependentName { get; set; }
        public string DependentSex { get; set; }
        public DateTime DependentBirthDate { get; set; }
        public string DependentRelationship { get; set; }


        //DEPENDENTS_OF
        [ForeignKey("E")]
        public int EmployeeId { get; set; }

        public Employee E { get; set; }
    }
}
