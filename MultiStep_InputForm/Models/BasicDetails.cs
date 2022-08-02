using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MultiStep_InputForm.Models
{
    public class BasicDetails
    {
        [Required]
        public string CustomerID { get; set; }
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }
    }
}