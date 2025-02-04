using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class Appointment : Auditables
    {
        public Doctor Doctor { get; set; }
        public Student Student { get; set; }
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}
