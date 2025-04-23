using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForHotel.Exceptions;

public class RoomException : Exception
{
    public RoomException(string message) : base(message) { }
}
