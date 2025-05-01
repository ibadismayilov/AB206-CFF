using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUsing.Core.Interfaces;

public abstract class BaseClass
{
    public int Id { get; set; }
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
}
