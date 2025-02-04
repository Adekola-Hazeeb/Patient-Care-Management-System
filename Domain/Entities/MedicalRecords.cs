using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class MedicalRecords: Auditables
    {
        public Student Student { get; set; }
        public string Notes { get; set; }
        public Doctor Doctor { get; set; }  
        public RecordType RecordType { get; set; }
    }
}
