using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace SelectInDepth.BOL.DataModel
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int Pid { get; set; }
        public string ProjectName { get; set; }

        public virtual IEnumerable<Module> Modules { get; set; }
    }
}
