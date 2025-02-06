using Patient_Care_Management_System.Domain.Entities;
using Patient_Care_Management_System.Infrastructure.Context;

namespace Patient_Care_Management_System.Infrastructure.Repositories.Implementations
{
    public class SurgicalResultRepository : GenericRepository<SurgicalResult>
    {
        public SurgicalResultRepository(PatientCareManagementSystemDb context) : base(context) { }
    }
}
