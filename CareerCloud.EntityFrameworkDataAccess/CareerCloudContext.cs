using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext : DbContext
    {
        public DbSet <ApplicantEducationPoco>ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistory { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLog { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            string _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;

            optionsBuilder.UseSqlServer(_connStr);
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void 
            OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEducationPoco>
               (entity =>
               {
                   entity.HasOne(e => e.ApplicantProfile).
                   WithMany(p => p.ApplicantEducations).
                   HasForeignKey(e => e.Applicant);

               });

            modelBuilder.Entity<ApplicantProfilePoco>
             (entity =>
             {
                 entity.HasOne(p => p.SecurityLogins).
                 WithMany(s => s.ApplicantProfiles).
                 HasForeignKey(p => p.Login);
             });


            modelBuilder.Entity<ApplicantSkillPoco>
               (entity =>
               {
                   entity.HasOne(s => s.ApplicantProfiles).
                   WithMany(p => p.ApplicantSkills).
                   HasForeignKey(s => s.Applicant);

               });

            modelBuilder.Entity<ApplicantJobApplicationPoco>
               (entity =>
               {
                   entity.HasOne(a => a.ApplicantProfiles).
                   WithMany(p => p.ApplicantJobApplications).
                   HasForeignKey(a => a.Applicant);

               });

            modelBuilder.Entity<ApplicantJobApplicationPoco>
               (entity =>
               {

                   entity.HasOne(a => a.CompanyJobs).
                   WithMany(c => c.ApplicantJobApplications).
                   HasForeignKey(a => a.Job);
               });

            modelBuilder.Entity<ApplicantResumePoco>
             (entity =>
             {
                 entity.HasOne(r => r.ApplicantProfiles).
                 WithMany(p => p.ApplicantResumes).
                 HasForeignKey(r => r.Applicant);

             });


            modelBuilder.Entity<ApplicantWorkHistoryPoco>
               (entity =>
               {
                   entity.HasOne(w => w.ApplicantProfiles).
                   WithMany(p => p.ApplicantWorkHistory).
                   HasForeignKey(w => w.Applicant);
               });

            modelBuilder.Entity<ApplicantWorkHistoryPoco>
               (entity =>
               {
                   entity.HasOne(w => w.SystemCountryCodes).
                   WithMany(p => p.ApplicantWorkHistory).
                   HasForeignKey(w => w.CountryCode);
               });

            modelBuilder.Entity<SecurityLoginsLogPoco>
              (entity =>
              {
                  entity.HasOne(p => p.SecurityLogins).
                  WithMany(s => s.SecurityLoginsLog).
                  HasForeignKey(p => p.Login);

              });



            modelBuilder.Entity<CompanyJobSkillPoco>
               (entity =>
               {
                   entity.HasOne(cs => cs.CompanyJobs).
                   WithMany(cj => cj.CompanyJobSkills).
                   HasForeignKey(cs => cs.Job);
               });

            modelBuilder.Entity<CompanyJobEducationPoco>
               (entity =>
               {
                   entity.HasOne(ce => ce.CompanyJobs).
                   WithMany(cj => cj.CompanyJobEducations).
                   HasForeignKey(ce => ce.Job);
               });

            modelBuilder.Entity<CompanyJobDescriptionPoco>
               (entity =>
               {
                   entity.HasOne(cd => cd.CompanyJobs).
                   WithMany(cj => cj.CompanyJobDescriptions).
                   HasForeignKey(cd => cd.Job);
               });

            modelBuilder.Entity<CompanyJobPoco>
               (entity =>
               {
                   entity.HasOne(cj => cj.CompanyProfiles).
                   WithMany(cp => cp.CompanyJobs).
                   HasForeignKey(cj => cj.Company);
               });

       
            modelBuilder.Entity<ApplicantProfilePoco>
               (entity =>
               {
                  entity.HasOne(p => p.SystemCountryCodes).
                  WithMany(s => s.ApplicantProfiles).
                  HasForeignKey(p => p.Country);
               });

           

            modelBuilder.Entity<SecurityLoginsRolePoco>
               (entity =>
               {
                   entity.HasOne(p => p.SecurityLogins).
                   WithMany(s => s.SecurityLoginsRoles).
                   HasForeignKey(p => p.Login);
                   

               });

            modelBuilder.Entity<SecurityLoginsRolePoco>
               (entity =>
               {
                
                   entity.HasOne(sl => sl.SecurityRoles).
                   WithMany(sr => sr.SecurityLoginsRoles).
                   HasForeignKey(sl => sl.Role);

               });

            modelBuilder.Entity<CompanyDescriptionPoco>
              (entity =>
              {
                  entity.HasOne(e => e.CompanyProfiles)
                  .WithMany(p => p.CompanyDescriptions)
                  .HasForeignKey(e => e.Company);

                  entity.HasOne(s1 => s1.SystemLanguageCode)
                  .WithMany(cd => cd.CompanyDescriptions)
                  .HasForeignKey(f => f.LanguageId);
               });


            modelBuilder.Entity<CompanyLocationPoco>
               (entity =>
               {
                   entity.HasOne(e => e.CompanyProfiles)
                  .WithMany(p => p.CompanyLocations)
                  .HasForeignKey(e => e.Company);

               });

           
            base.OnModelCreating(modelBuilder);
        }
        private void entity(EntityTypeBuilder<ApplicantProfilePoco> obj)
        {
            throw new NotImplementedException();
        }


    }
}
