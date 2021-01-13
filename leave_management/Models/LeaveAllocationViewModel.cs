using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }

    }
    public class CreateLeaveAllocationViewModel
    {
        public int NumberUpdated { get; set; }

        public List<LeaveTypeViewModel> LeaveTypes { get; set; }

    }

    public class EditAllocationViewModel
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public string EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }
    }

    public class ViewAllocationViewModel
    {
        public EmployeeViewModel Employee { get; set; }

        public string EmployeeId { get; set; }

        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
    }
}
