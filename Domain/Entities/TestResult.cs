namespace Patient_Care_Management_System.Domain.Entities
{
    public class TestResult: MedicalRecords
    {
        public List<TestResultItem> TestItems { get; set; } = new List<TestResultItem>();
        public DateTime DateConducted { get; set; } 
    }
}
