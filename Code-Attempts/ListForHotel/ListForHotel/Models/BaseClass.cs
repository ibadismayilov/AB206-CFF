using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForHotel.Models;

public abstract class BaseClass
{
    private static int _id;
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
    public string Name { get; set; }

    protected BaseClass(string name)
    {
        Id = ++_id;
        Name = name;
    }
}
