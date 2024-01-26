﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DAL;

namespace UI.Models
{
    public class PolicyViewModel
    {
        [Required(ErrorMessage = "Policy Number is required")]
        public string PolicyNumber { get; set; }



        [Required(ErrorMessage = "Applied Date is required")]
        [DataType(DataType.Date)]
        public DateTime AppliedDate { get; set; }

        
        public string Category { get; set; }

        
    }


}