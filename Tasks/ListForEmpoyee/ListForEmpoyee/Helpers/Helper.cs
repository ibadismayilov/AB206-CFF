using ListForEmpoyee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListForEmpoyee.Helper;

public static class Helper
{

    public static bool CheckFullname(string name, string surname, Employee employee)
    {
        string fullname = name + " " + surname;
        return fullname == employee.Fullname;
    }
}
