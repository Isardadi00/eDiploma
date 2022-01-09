using System.Collections.Generic;
using System;

namespace eDiploma.Models.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}