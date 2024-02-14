using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SelectInDepth.BOL.DataModel
{
    [Table("Module")]
    public class Module
    {
        [Key]
        public int Mid { get; set; }
        public string ModuleName { get; set; }

        [ForeignKey("ProjectNvg")]
        public int Pid { get; set; }
        public virtual Project ProjectNvg { get; set; }

        public virtual IEnumerable<Task> Tasks { get; set; }
    }
}
