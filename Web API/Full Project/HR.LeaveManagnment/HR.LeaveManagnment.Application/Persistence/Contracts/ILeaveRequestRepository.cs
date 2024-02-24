using HR.LeaveManagnment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagnment.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
    }
}
