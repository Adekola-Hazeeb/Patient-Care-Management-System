using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class Diagnosis : MedicalRecords
    {
        public string ConditionName { get; set; } 
        public DiagnosisSeverity Severity { get; set; } 
        public string Symptoms { get; set; } 
        public string RecommendedTreatment { get; set; }
    }
}
