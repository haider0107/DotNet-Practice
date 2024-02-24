using HR.LeaveManagnment.Application.DTOs.Common;
using HR.LeaveManagnment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagnment.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }
    }
}
