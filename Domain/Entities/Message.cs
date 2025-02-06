namespace Patient_Care_Management_System.Domain.Entities
{
    public class Message : Auditables
    {
        public Guid DoctorId { get; set; }
        public Guid StudentId { get; set; }
        public string? Content { get; set; }
    }
}
