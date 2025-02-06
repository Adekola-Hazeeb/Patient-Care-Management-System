namespace Patient_Care_Management_System.Domain.Entities
{
    public class Pharmacist: User
    {
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
