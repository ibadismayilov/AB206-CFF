using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManagementApp.Models.UserDepartment;
using static ManagementApp.Models.UserGender;

namespace ManagementApp.Models;

public class Doctor
{
    public int _doctor_id = 1;
    public int DoctorID
    {
        get
        {
            return _doctor_id;
        }

        set
        {
            _doctor_id = value;
        }
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int ExperienceYear { get; set; }
    public Genders Gender { get; set; }
    public Department DepartmentEnum { get; set; }

    public Doctor(string name, string surname, int age, int experienceYear, Genders gender, Department departmentEnum)
    {
        DoctorID = _doctor_id++;
        Name = name;
        Surname = surname;
        Age = age;
        ExperienceYear = experienceYear;
        Gender = gender;
        DepartmentEnum = departmentEnum;
    }

}
