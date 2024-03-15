using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bowlingApp.Data
{
    public partial class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public string TeamName { get; set; } = "";

        public int? CaptainID { get; set; }
    }
}
