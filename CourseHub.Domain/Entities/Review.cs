using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; } = default!;
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;

        public int Rating { get; set; } // Rating out of 5
        public string Comment { get; set; } = string.Empty;
    }
}
