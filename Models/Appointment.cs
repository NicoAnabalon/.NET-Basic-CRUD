using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCRUD.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
