using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class LabPhysician : User
    {
        public List<TestResult> TestResults { get; set; } = new List<TestResult>();
    }
}
