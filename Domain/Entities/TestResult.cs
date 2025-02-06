namespace Patient_Care_Management_System.Domain.Entities
{
    public class TestResult: MedicalRecord
    {
        public string LabPhysicianId { get; set; }
        public LabPhysician LabPhysician { get; set; }
        public List<TestResultItem> TestItems { get; set; } = new List<TestResultItem>();
        public DateTime DateConducted { get; set; } 
    }
}
