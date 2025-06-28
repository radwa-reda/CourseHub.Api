namespace CourseHub.Domain.Entities
{
    public class Course: BaseEntity
    { public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; } = default!;
        public int CategoryId { get; set; }
        public Instructor Instructor { get; set; }
        public int InstructorId { get; set; }

        public decimal Price { get; set; } 
        public bool IsPublished { get; set; } 
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Lesson> Lessons { get; set; }= new List<Lesson>();
    }
}
