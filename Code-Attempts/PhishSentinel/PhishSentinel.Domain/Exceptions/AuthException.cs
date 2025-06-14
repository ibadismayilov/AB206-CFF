using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhishSentinel.Domain.Exceptions;
public class AuthException : Exception
{
    public AuthException() : base("Default Exception") { }

    public AuthException(string message) : base(message) { }
}
