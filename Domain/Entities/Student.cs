using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class Student : User
    {
        public string MatricNumber { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public string Tribe { get; set; } = default!;
        public MaritalStatus MaritalStatus { get; set; } = default!;
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public List<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    }
}
