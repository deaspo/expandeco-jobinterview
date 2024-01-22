using System;
using System.ComponentModel.DataAnnotations;

namespace Expandeco.JobInterview.Data 
{
    public class Deadline 
    {
        public int Id { get; set; }

        public string DeadlineDateTimeString { get; set; }
        public bool ExpiredDeadline { get; set; }
        [Required]
        public DateTime DeadlineDateTime { get; set; }
    }
}