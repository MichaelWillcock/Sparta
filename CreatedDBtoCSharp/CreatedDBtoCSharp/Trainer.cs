using System;
using System.Collections.Generic;

#nullable disable

namespace CreatedDBtoCSharp
{
    public partial class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
    }
}
