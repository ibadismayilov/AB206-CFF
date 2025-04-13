using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManagementApp.Models.UserGender;

namespace ManagementApp.Models;

public class Patient
{
    public int _patiend_id = 1;
    public int PatiendID
    {
        get
        {
            return _patiend_id;
        }
        set
        {
            _patiend_id = value;
        }
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public Genders Gender { get; set; }

    public Patient(string name, string surname, Genders genders)
    {
        PatiendID = _patiend_id++;
        Name = name;
        Surname = surname;
        Gender = genders;
    }
}
