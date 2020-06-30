﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
       // [ForeignKey("FK_Applicant_Resumes_Applicant_Profiles")]
        public Guid Applicant { get; set; }
        public String Resume { get; set; }
        [Column("Last_Updated")]
        public DateTime? LastUpdated { get; set; }
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }
    }
}
