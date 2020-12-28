using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
    public class CreateLeaveTypeViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
