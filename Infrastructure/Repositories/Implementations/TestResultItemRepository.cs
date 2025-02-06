using Patient_Care_Management_System.Application.Interfaces.Repositories;
using Patient_Care_Management_System.Domain.Entities;
using Patient_Care_Management_System.Infrastructure.Context;

namespace Patient_Care_Management_System.Infrastructure.Repositories.Implementations
{
    public class TestResultItemRepository : GenericRepository<TestResultItem>,ITestResultItemRepository
    {
        public TestResultItemRepository(PatientCareManagementSystemDb context) : base(context) { }
    }
}
