using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
    
        public Student StudentProfile { get; set; } = default!;
        public Instructor InstructorProfile { get; set; } = default!;
        public string RoleType { get; set; }
    }
}
