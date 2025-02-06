namespace Patient_Care_Management_System.Domain.Entities
{
    public class MedicalReferral : MedicalRecord
    {
        public string ReferredSpecialist { get; set; }  
        public string ReasonForReferral { get; set; }
    }
}
