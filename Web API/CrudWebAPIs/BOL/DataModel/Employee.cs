using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SelectInDepth.BOL.DataModel
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string? EName { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }

        [ForeignKey("DepartmentNvg")]
        public int? Did { get; set; }
        public virtual Department? DepartmentNvg { get; set; }
        public virtual IEnumerable<Task>? Tasks { get; set; }
    }
}
