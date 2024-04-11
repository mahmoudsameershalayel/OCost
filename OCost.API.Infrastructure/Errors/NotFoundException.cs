﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.API.Infrastructure.Errors
{
    public abstract class NotFoundException : Exception
    {
         protected NotFoundException(string message) : base(message){ }
    }
}
