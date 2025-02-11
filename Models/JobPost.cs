﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreelancingSystem.Models
{
    public class JobPost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobPostID { get; set; }
        
        [Display(Name="Job Name")]
        public string Name { get; set; }  = string.Empty;
        public int ClientID { get; set; }

        
        public string Discreption { get; set; }   = string.Empty;

        [Required(ErrorMessage ="Enter budget")]
        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }
        // fixed or hourly
        
        public string Type { get; set; } 
        // initialized when object is instantiated to the time of object creation
        [Display(Name ="Creation Date")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [Display(Name = "Proposals")]
        public int NumOfProposals { get; set; }
        //freelancer id = 0 if no freelancer is assigned
        public int FreelancerId { get; set; } 
        // true if approved by admin otherwise false
        public bool Approved { get; set; } = false;
        
        [Display(Name="Client Name")]
        public string ClientName { get; set; }

    }
}