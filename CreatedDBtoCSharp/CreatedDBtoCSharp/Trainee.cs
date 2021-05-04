using System;
using System.Collections.Generic;

#nullable disable

namespace CreatedDBtoCSharp
{
    public partial class Trainee
    {
        public int TraineeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Course { get; set; }
        public string Trainer { get; set; }
        public string Email { get; set; }
        public string Progress { get; set; }
    }
}
