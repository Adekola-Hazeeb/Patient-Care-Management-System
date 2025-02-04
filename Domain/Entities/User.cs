using System.Data;
using Patient_Care_Management_System.Domain.Enums;

namespace Patient_Care_Management_System.Domain.Entities
{
    public class User: Auditables
    {
        public string Email { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public Gender Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string Salt { get; set; } = null!;
        public Roles Role { get; set; }
    }
}
