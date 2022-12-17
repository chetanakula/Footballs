using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Footballs.Models
{
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "MatchID cannot be  negative or zero")]

        public string TeamName1 { get; set; }
        [StringLength(byte.MaxValue)]
        [Required(ErrorMessage = "TeamName1 must be specified")]
        public string TeamName2 { get; set;}
        [StringLength(byte.MaxValue)]
        [Required(ErrorMessage = "TeamName2 must be specified")]

        public string Status { get; set; }
         [Required(ErrorMessage = "Status must be specified")]

        public string WinningTeam { get; set; }
    }
}