

using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class Prescription : MedicalRecord
    {
       public List<PrescriptionItem> Medications { get; set; } = new List<PrescriptionItem>();
        public Pharmacist? Pharmacist { get; set; }
        public string PharmacistId { get ; set; }
        public PrescriptionStatus PrescriptionStatus { get; set; }
    }
}
