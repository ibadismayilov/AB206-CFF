using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Domain.Exceptions;

public class ProductEntityException : Exception
{
    public ProductEntityException() : base("Default Message") { }

    public ProductEntityException(string message) : base(message) { }
}

