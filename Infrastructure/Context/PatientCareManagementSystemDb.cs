using Microsoft.EntityFrameworkCore;
using Patient_Care_Management_System.Domain.Entities;

namespace Patient_Care_Management_System.Infrastructure.Context
{
    public class PatientCareManagementSystemDb : DbContext
    {

        public PatientCareManagementSystemDb(DbContextOptions<PatientCareManagementSystemDb> options) : base(options) { }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<LabPhysician> LabPhysicians { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<MedicalReferral> MedicalReferrals { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Pharmacist> Pharmacists { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SurgicalResult> SurgicalResults { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<TestResultItem> TestResultItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Appointment>()
      .HasKey(a => a.Id);
            modelBuilder.Entity<MedicalRecord>()
      .HasKey(a => a.Id);
            modelBuilder.Entity<Prescription>()
          .ToTable("Prescriptions");
            modelBuilder.Entity<PrescriptionItem>()
.HasKey(a => a.Id);
            modelBuilder.Entity<TestResultItem>()
.HasKey(a => a.Id);
            modelBuilder.Entity<User>()
.HasKey(a => a.Id);
        }
    }

}
