using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
       // [ForeignKey("FK_Applicant_Profiles_Security_Logins")]
        public Guid Login { get; set; }
        [Column("Current_Salary")]
        public Decimal? CurrentSalary { get; set; }
        [Column("Current_Rate")]
        public Decimal? CurrentRate { get; set; }
        [StringLength(10)]
        public String Currency { get; set; }
        [Column("Country_Code")]
        [StringLength(10)]
     //   [ForeignKey("FK_Applicant_Profiles_System_Country_Codes")]
        public String Country { get; set; }
        [Column("State_Province_Code")]
        [StringLength(10)]
        public String Province { get; set; }
        [Column("Street_Address")]
        [StringLength(100)]
        public String Street { get; set; }
        [Column("City_Town")]
        [StringLength(100)]
        public String City { get; set; }
        [Column("Zip_Postal_Code")]
        [StringLength(20)]
        public String PostalCode { get; set; }
        [Column("Time_Stamp")]
        [MaxLength(8)]
        [Timestamp]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }

        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public virtual SecurityLoginPoco SecurityLogins { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public virtual ICollection<ApplicantResumePoco> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistory { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCodes { get; set; }
    }
}
