namespace Patient_Care_Management_System.Domain.Entities
{
    public class MedicalReferrals : MedicalRecords
    {
        public string ReferredSpecialist { get; set; }  
        public string ReasonForReferral { get; set; }
    }
}
