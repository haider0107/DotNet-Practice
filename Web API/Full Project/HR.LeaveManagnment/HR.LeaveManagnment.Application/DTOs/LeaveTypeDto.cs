using HR.LeaveManagnment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagnment.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public string DefaultDays { get; set; }
    }
}
