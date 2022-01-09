using System.Collections.Generic;
using System;

namespace eDiploma.Models.Entities
{
    public class Diploma
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public int Units { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public float Grade { get; set; }
        public string Other { get; set; }

        // DB connection

        public User User { get; set; }
        public School School { get; set; }
    }
}