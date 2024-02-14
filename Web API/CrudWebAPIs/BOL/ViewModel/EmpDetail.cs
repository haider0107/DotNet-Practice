using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SelectInDepth.BOL.ViewModel
{
    //[NotMapped]
    public class EmpDetail
    {
        [Key]
        public int Eid { get; set; }
        public string EName { get; set; }
        public string DName { get; set; }
    }
}
