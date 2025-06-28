using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class Lesson: BaseEntity
    {
      
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string VideoPublicId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
    }
}
