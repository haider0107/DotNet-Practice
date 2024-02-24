using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagnment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
