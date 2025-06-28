using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class Instructor: BaseEntity
    {
       
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Bio { get; set; }
        public string ProfileImageUrl { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
