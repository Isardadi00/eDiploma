using System.Collections.Generic;
using System;

namespace eDiploma.Models.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public float Grade { get; set; }
        public string Teacher { get; set; }
        public DateTime CourseStarted { get; set; }
        public DateTime CourseEnded { get; set; }

        // DB connection
        public Diploma Diploma { get; set; }
    }
}