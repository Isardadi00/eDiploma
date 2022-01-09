namespace eDiploma.Models.DTOs
{
    public class CourseDTO
    {
        
        public float Grade { get; set; }
        public string? Teacher { get; set; }
        public DateTime CourseStarted { get; set; }
        public DateTime? CourseEnded { get; set; }
    }
}