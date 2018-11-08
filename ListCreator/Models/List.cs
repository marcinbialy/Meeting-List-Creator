using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListCreator.Models
{
    public class List
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Meeting date")]
        public DateTime MeetingDate { get; set; }
        [Display(Name = "Short Note")]
        public string Describ { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
