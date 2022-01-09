namespace eDiploma.Models.DTOs
{
    public class DiplomaDTO
    {
        public string Degree { get; set; }
        public int Units { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public float Grade { get; set; }
        public string? Other { get; set; }

        public UserDTO User { get; set; }

        public SchoolDTO School { get; set; }
    }
}