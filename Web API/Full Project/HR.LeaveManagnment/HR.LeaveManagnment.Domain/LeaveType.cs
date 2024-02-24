using HR.LeaveManagnment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagnment.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public string DefaultDays { get; set; }
    }
}
