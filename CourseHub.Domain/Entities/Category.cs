using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHub.Domain.Entities
{
    public class Category: BaseEntity
    {
       
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
