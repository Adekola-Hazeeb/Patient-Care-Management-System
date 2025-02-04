namespace Patient_Care_Management_System.Domain.Entities
{
    public class MedicalHistory : Auditables
    {
        public Student Student { get; set; }
        public List<TestResult> TestResults { get; set; } = new List<TestResult>();
        public List<SurgicalResult> SurgicalResults { get; set; } = new List<SurgicalResult>();
        public List<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        public List<MedicalReferral> Prescriptions { get; set; } = new List<MedicalReferral>();
    }
}
