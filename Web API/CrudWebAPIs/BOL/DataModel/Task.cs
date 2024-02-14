using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SelectInDepth.BOL.DataModel
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public int Tid { get; set; }
        public string TaskName { get; set; }

        [ForeignKey("ModuleNvg")]
        public int Mid { get; set; }
        public virtual Module ModuleNvg { get; set; }

        [ForeignKey("EmployeeNvg")]
        public int Eid { get; set; }
        public virtual Employee EmployeeNvg { get; set; }
    }
}