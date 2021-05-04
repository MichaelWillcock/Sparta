using System;
using System.Collections.Generic;

#nullable disable

namespace CreatedDBtoCSharp
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public string AbreviatedName { get; set; }
        public string Trainer { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NumberOfTrainees { get; set; }
        public string Location { get; set; }
    }
}
