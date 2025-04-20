using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayListConsoleApp.Exceptions;

public class PlayListException : Exception
{
    public PlayListException(string message) : base(message)
    {
        
    }
}
