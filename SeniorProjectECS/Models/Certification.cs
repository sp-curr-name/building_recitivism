﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProjectECS.Models
{
    public class Certification
    {
        public int CertificationID { get; set; }
        [DisplayName("Certification Name")]
        public String CertName { get; set; }
        [DisplayName("Months Cert is Valid")]
        public int CertExpireAmount { get; set; }
    }
}
