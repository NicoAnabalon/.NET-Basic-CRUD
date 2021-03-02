using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCRUD.Models
{
    public enum Specialty
    {
        General, Nutricion, Neurologo
    }
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string RUT { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Specialty Specialty { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
