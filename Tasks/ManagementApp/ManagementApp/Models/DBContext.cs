using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManagementApp.Models.UserDepartment;
using static ManagementApp.Models.UserGender;
using System.Xml.Linq;

namespace ManagementApp.Models;

public static class DBContext
{
    public static Patient[] patients;
    public static Doctor[] doctors;
    public static Appointment[] appointments;

    static DBContext()
    {
        patients = new Patient[0];
        doctors = new Doctor[0];
        appointments = new Appointment[0];
    }

    static public void AddNewPatient(Patient patient)
    {
        if (patient is null)
        {
            Array.Resize(ref patients, 1);
            patients[patients.Length - 1] = patient;
        }
        else
        {
            Array.Resize(ref patients, patients.Length + 1);
            patients[patients.Length - 1] = patient;
        }
    }
    public static void AddNewDoctor(Doctor doctor)
    {
        if (doctor is null)
        {
            Array.Resize(ref doctors, 1);
            doctors[doctors.Length - 1] = doctor;
        }
        else
        {
            Array.Resize(ref doctors, doctors.Length + 1);
            doctors[doctors.Length - 1] = doctor;
        }
    }

    public static void AddNewAppointment(Appointment appointment)
    {
        Doctor[] doctor = new Doctor[0];

        foreach (Patient item in patients)
        {

            if (item._patiend_id.Equals(appointment.PatientId))
            {
                Doctor newDoctor = new Doctor(item.Name, item.Surname, 20, 5, item.Gender, Department.Cərrahiyyə);


                Array.Resize(ref doctor, doctor.Length + 1);
                doctor[doctor.Length - 1] = newDoctor;
            }
        }
    }


    public static Patient[] GetAllPatient()
    {
        foreach (Patient item in patients)
        {
            if (item is null)
            {
                throw new Exception("Items is null");
            }
            else
            {
                Console.WriteLine($"{item._patiend_id} | {item.Name} {item.Surname} | {item.Gender}");
            }
        }
        return null;
    }
    public static Doctor[] GetAllDoctor()
    {

        foreach (Doctor item in doctors)
        {
            if (item is null)
            {
                throw new Exception("Items is null");
            }
            else
            {
                Console.WriteLine($"{item._doctor_id} | {item.Name} | {item.Surname} | {item.Gender} | {item.Age} | {item.DepartmentEnum}| {item.ExperienceYear}");
            }
        }
        return null;
    }

    public static Appointment[] GetAllAppointment()
    {
        return null;
    }
}
