using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManagementApp.Models.UserGender;

namespace ManagementApp.Models;

abstract class PersonBase
{
    public int _id;
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Genders Gender { get; set; }

}
