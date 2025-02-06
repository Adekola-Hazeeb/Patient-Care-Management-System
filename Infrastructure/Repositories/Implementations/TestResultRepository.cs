using Patient_Care_Management_System.Application.Interfaces.Repositories;
using Patient_Care_Management_System.Infrastructure.Context;

namespace Patient_Care_Management_System.Infrastructure.Repositories.Implementations
{
    public class TestResultRepository : GenericRepository<TestResultRepository>,ITestResultRepository
    {
        public TestResultRepository(PatientCareManagementSystemDb context) : base(context) { }
    }

}
