using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MultiStep_InputForm.Models
{
    public class ContactDetails
    {
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Fax { get; set; }
    }
}