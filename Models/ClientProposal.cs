﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreelancingSystem.Models
{
    // this class defines relation between client and his posts
    public class ClientProposal
    {
        [Key]
        public int ID { get; set; }
        public int PostID { get; set; }
        public int ClientID { get; set; }
    }
}