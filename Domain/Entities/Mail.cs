namespace Patient_Care_Management_System.Domain.Entities
{
    public class Mail : Auditables
    {
        public string Subject { get; set; } = default!;
        public string Message { get; set; } = default!;
        public Student Student { get; set; }
        public string SenderId { get; set; } = default!;
    }
}
