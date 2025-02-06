﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patient_Care_Management_System.Infrastructure.Context;

#nullable disable

namespace Patient_Care_Management_System.Migrations
{
    [DbContext(typeof(PatientCareManagementSystemDb))]
    partial class PatientCareManagementSystemDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Appointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.MedicalRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RecordType")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("StudentId");

                    b.ToTable("MedicalRecords");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.PrescriptionItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DurationInDays")
                        .HasColumnType("int");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MedicationName")
                        .HasColumnType("longtext");

                    b.Property<string>("PrescriptionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionItems");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.TestResultItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ReferenceRange")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TestResultId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("TestResultId");

                    b.ToTable("TestResultItems");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator().HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Diagnosis", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.MedicalRecord");

                    b.Property<string>("ConditionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecommendedTreatment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.MedicalReferral", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.MedicalRecord");

                    b.Property<string>("ReasonForReferral")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReferredSpecialist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("MedicalReferrals");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Prescription", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.MedicalRecord");

                    b.Property<string>("PharmacistId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("PrescriptionStatus")
                        .HasColumnType("int");

                    b.HasIndex("PharmacistId");

                    b.ToTable("Prescriptions", (string)null);
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.SurgicalResult", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.MedicalRecord");

                    b.Property<DateTime>("DatePerformed")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SurgeryType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("SurgicalResults");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.TestResult", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.MedicalRecord");

                    b.Property<DateTime>("DateConducted")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LabPhysicianId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasIndex("LabPhysicianId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Doctor", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.LabPhysician", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.User");

                    b.HasDiscriminator().HasValue("LabPhysician");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Nurse", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Nurse");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Pharmacist", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Pharmacist");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Receptionist", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Receptionist");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Student", b =>
                {
                    b.HasBaseType("Patient_Care_Management_System.Domain.Entities.User");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("MatricNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tribe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Appointment", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Patient_Care_Management_System.Domain.Entities.Student", "Student")
                        .WithMany("Appointments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.MedicalRecord", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.Doctor", "Doctor")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Patient_Care_Management_System.Domain.Entities.Student", "Student")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.PrescriptionItem", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.Prescription", "Prescription")
                        .WithMany("Medications")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.TestResultItem", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.TestResult", "TestResult")
                        .WithMany("TestItems")
                        .HasForeignKey("TestResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestResult");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Prescription", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.MedicalRecord", null)
                        .WithOne()
                        .HasForeignKey("Patient_Care_Management_System.Domain.Entities.Prescription", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Patient_Care_Management_System.Domain.Entities.Pharmacist", "Pharmacist")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PharmacistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pharmacist");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.SurgicalResult", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.MedicalRecord", null)
                        .WithOne()
                        .HasForeignKey("Patient_Care_Management_System.Domain.Entities.SurgicalResult", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.TestResult", b =>
                {
                    b.HasOne("Patient_Care_Management_System.Domain.Entities.MedicalRecord", null)
                        .WithOne()
                        .HasForeignKey("Patient_Care_Management_System.Domain.Entities.TestResult", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Patient_Care_Management_System.Domain.Entities.LabPhysician", "LabPhysician")
                        .WithMany("TestResults")
                        .HasForeignKey("LabPhysicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LabPhysician");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Prescription", b =>
                {
                    b.Navigation("Medications");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.TestResult", b =>
                {
                    b.Navigation("TestItems");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.LabPhysician", b =>
                {
                    b.Navigation("TestResults");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Pharmacist", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Patient_Care_Management_System.Domain.Entities.Student", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
