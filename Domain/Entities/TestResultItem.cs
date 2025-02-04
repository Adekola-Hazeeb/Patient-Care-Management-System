namespace Patient_Care_Management_System.Domain.Entities
{
    public class TestResultItem
    {
        public int Id { get; set; }
        public string TestName { get; set; }  
        public string Result { get; set; }  
        public string Unit { get; set; } 
        public string ReferenceRange { get; set; } 
    }
}
