

namespace Patient_Care_Management_System.Domain.Entities
{
    public class Prescription : MedicalRecords
    {
       public List<PrescriptionItem> Medications { get; set; } = new List<PrescriptionItem>();
    }
}
