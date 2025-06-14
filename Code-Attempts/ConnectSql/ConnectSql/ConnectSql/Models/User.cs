using ConnectSql.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectSql.Models;

public class User : BaseClass
{
    public string Name { get; set; }
    public int Password { get; set; }

}
