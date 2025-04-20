using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayListConsoleApp.Core.Interfaces;

public abstract class BaseClass
{
    private static int counter = 0;
    private int id;

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    protected BaseClass()
    {
        Id = ++counter;
    }
}
