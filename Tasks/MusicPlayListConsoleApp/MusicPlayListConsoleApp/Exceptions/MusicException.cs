﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayListConsoleApp.Exceptions;

public class MusicException : Exception
{
    public MusicException(string message) : base(message) 
    {
        
    }
}
