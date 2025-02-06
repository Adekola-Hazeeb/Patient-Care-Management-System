using System.ComponentModel.DataAnnotations;

namespace Patient_Care_Management_System.Domain.Entities
{
    public abstract class Auditables
    {
        [Key]
        public string Id = Guid.NewGuid().ToString().Substring(0, 5);
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
