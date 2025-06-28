using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class Student: BaseEntity
    {

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }
}
