namespace Patient_Care_Management_System.Domain.Entities
{
    public class TestResultItem : Auditables
    {
        public string TestName { get; set; }  
        public string Result { get; set; }  
        public string Unit { get; set; } 
        public string ReferenceRange { get; set; } 
        public TestResult TestResult { get; set; }
        public string TestResultId { get; set; }
    }
}
