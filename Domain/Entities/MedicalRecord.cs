using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class MedicalRecord: Auditables
    {
        public Student Student { get; set; }
        public string StudentId { get; set; }
        public string Notes { get; set; }
        public Doctor Doctor { get; set; }
        public string DoctorId { get; set; }
        public RecordType RecordType { get; set; }
    }
}
