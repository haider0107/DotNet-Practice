using AutoMapper;
using HR.LeaveManagnment.Application.DTOs;
using HR.LeaveManagnment.Application.DTOs.LeaveRequest;
using HR.LeaveManagnment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagnment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
        }
    }
}
