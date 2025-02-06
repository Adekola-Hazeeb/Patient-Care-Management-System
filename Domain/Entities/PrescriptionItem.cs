namespace Patient_Care_Management_System.Domain.Entities
{
    public class PrescriptionItem : Auditables
    {
        public string? MedicationName { get; set; }
        public string Dosage { get; set; } 
        public string Frequency { get; set; } 
        public int DurationInDays { get; set; } 
        public Prescription Prescription { get; set; }
        public string PrescriptionId { get; set; }
    }
}

