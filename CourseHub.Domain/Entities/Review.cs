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
        public Student Student { get; set; } = default!;
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;

        public int Rating { get; set; } 
        public string Comment { get; set; } = string.Empty;

        //suggest
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
