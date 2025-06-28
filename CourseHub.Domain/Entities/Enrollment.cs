using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        //suggest
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

    }
}
