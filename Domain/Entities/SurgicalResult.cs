﻿namespace Patient_Care_Management_System.Domain.Entities
{
    public class SurgicalResult : MedicalRecord
    {
        public DateTime DatePerformed { get; set; }
        public string SurgeryType { get; set; }

    }
}
