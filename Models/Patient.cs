using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCRUD.Models
{
    public enum BloodType
    {
        ABPositivo, ABNegativo, APositivo, ANegativo, BPositivo, BNegativo, OPositivo, ONegativo
    }
    public enum HealthSystem
    {
        Fonasa, Isapre
    }
    public class Patient
    {
        public int PatientID { get; set; }
        public string RUT { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BloodType BloodType { get; set; }
        public HealthSystem HealthSystem { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
