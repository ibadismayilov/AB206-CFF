using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.Models;

public class Appointment
{
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime DateTime { get; set; }

    public Appointment(int patienrID, int doctorID, DateTime dateTime)
    {
        PatientId = patienrID;
        DoctorId = doctorID;
        DateTime = dateTime;
    }
}
