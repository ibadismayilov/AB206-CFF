using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor;

class UserModel
{
    public string email;
    private string _password;
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }
    }

    public UserModel(string email, string password)
    {
        this.email = email;
        this._password = password;
    }
}
